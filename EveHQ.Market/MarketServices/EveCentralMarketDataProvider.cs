// ==============================================================================
// 
// EveHQ - An Eve-Online™ character assistance application
// Copyright © 2005-2015  EveHQ Development Team
//   
// This file is part of EveHQ.
//  
// The source code for EveHQ is free and you may redistribute 
// it and/or modify it under the terms of the MIT License. 
// 
// Refer to the NOTICES file in the root folder of EVEHQ source
// project for details of 3rd party components that are covered
// under their own, separate licenses.
// 
// EveHQ is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the MIT 
// license below for details.
// 
// ------------------------------------------------------------------------------
// 
// The MIT License (MIT)
// 
// Copyright © 2005-2015  EveHQ Development Team
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
// 
// ------------------------------------------------------------------------------
// 
// <copyright file="EveCentralMarketDataProvider.cs" company="EveHQ Development Team">
//     Copyright © 2005-2015  EveHQ Development Team
// </copyright>
// 
// ==============================================================================

namespace EveHQ.Market.MarketServices
{
    /// <summary>
    ///     Market data provider, sourcing data from Eve-Central.com
    /// </summary>
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Web;
    using System.Xml.Linq;
    using EveHQ.Caching;
    using EveHQ.Common;
    using EveHQ.Common.Extensions;
    using EveHQ.Market.UnifiedMarketDataFormat;

    public class EveCentralMarketDataProvider : IMarketStatDataProvider, IMarketDataReceiver, IMarketOrderDataProvider
    {
        /// <summary>The eve central base url.</summary>
        private const string EveCentralBaseUrl = "http://api.eve-central.com/api/";

        /// <summary>The item key format.</summary>
        private const string ItemKeyFormat = "{0}-{1}";

        /// <summary>The Jita system ID.</summary>
        private const int JitaSystemId = 30000142;

        /// <summary>The market stat API.</summary>
        private const string MarketStatApi = "marketstat";

        /// <summary>The min quantity.</summary>
        private const string MinQuantity = "minQ";

        /// <summary>
        ///     quicklook (detailed) API
        /// </summary>
        private const string QuickLookApi = "quicklook";

        /// <summary>The region.</summary>
        private const string Region = "Region";

        /// <summary>The region limit.</summary>
        private const string RegionLimit = "regionlimit";

        /// <summary>The type id.</summary>
        private const string TypeId = "typeid";

        /// <summary>The name of the parameter to set UDF data to.</summary>
        private const string UdfPostParameterName = "data";

        /// <summary>The upload API.</summary>
        private const string UploadApi = "upload";

        /// <summary>The use system.</summary>
        private const string UseSystem = "usesystem";

        /// <summary>The _cache ttl.</summary>
        private readonly TimeSpan _cacheTtl = TimeSpan.FromHours(1);

        /// <summary>The _market order cache.</summary>
        private readonly ICacheProvider _marketOrderCache;

        /// <summary>The _region data cache.</summary>
        private readonly ICacheProvider _regionDataCache;

        /// <summary>The _request provider.</summary>
        private readonly IHttpRequestProvider _requestProvider;

        /// <summary>The _upload key.</summary>
        private readonly UploadKey _uploadKey = new UploadKey { Key = "0", Name = "Eve-Central" };

        /// <summary>The _next upload attempt.</summary>
        private DateTimeOffset _nextUploadAttempt;

        /// <summary>The _upload service online.</summary>
        private bool _uploadServiceOnline;

        /// <summary>Initializes a new instance of the <see cref="EveCentralMarketDataProvider" /> class.</summary>
        /// <param name="cacheRootFolder">The cache root folder.</param>
        /// <param name="requestProvider">The request Provider.</param>
        public EveCentralMarketDataProvider(string cacheRootFolder, IHttpRequestProvider requestProvider)
        {
            _regionDataCache = new TextFileCacheProvider(Path.Combine(cacheRootFolder, Region));
            _marketOrderCache = new TextFileCacheProvider(Path.Combine(cacheRootFolder, "MarketOrders"));
            _requestProvider = requestProvider;
        }

        /// <summary>Gets the name.</summary>
        public static string Name
        {
            get { return "Eve-Central (Live Queries)"; }
        }

        /// <summary>Gets a value indicating whether is enabled.</summary>
        public bool IsEnabled
        {
            get { return _uploadServiceOnline; }
        }

        /// <summary>Gets the next attempt.</summary>
        public DateTimeOffset NextAttempt
        {
            get { return _nextUploadAttempt; }
        }

        /// <summary>Gets the unified upload key.</summary>
        public UploadKey UnifiedUploadKey
        {
            get { return _uploadKey; }
        }

        /// <summary>Attempts to upload the data values to the receiver</summary>
        /// <param name="marketData">The market data JSON string.</param>
        /// <returns>A reference to the Async Task.</returns>
        public Task UploadMarketData(string marketData)
        {
            // creat the URL for the request
            var requestUri = new Uri(EveCentralBaseUrl + UploadApi);
            var paramData = new NameValueCollection { { UdfPostParameterName, HttpUtility.UrlEncode(marketData) } };

            // send the request and return the task handle after checking the return of the web request
            return _requestProvider.PostAsync(requestUri, paramData).ContinueWith(
                task =>
                {
                    if (task.IsCompleted && !task.IsCanceled && !task.IsFaulted && task.Exception == null &&
                        task.Result != null && task.Result.IsSuccessStatusCode)
                    {
                        // success
                        _uploadServiceOnline = true;
                        _nextUploadAttempt = DateTimeOffset.Now;
                    }
                    else
                    {
                        // there was something wrong... disable this receiver for a while.
                        _uploadServiceOnline = false;
                        _nextUploadAttempt = DateTimeOffset.Now.AddHours(1);
                    }

                    return task;
                });
        }

        /// <summary>Gets the current market orders for the item, using the region, system and quantity constraints</summary>
        /// <param name="itemTypeId">The item ID to query</param>
        /// <param name="includedRegions">Regions to include in the query for data.</param>
        /// <param name="systemId">Specific system to use to source data (if set will overrride regions)</param>
        /// <param name="minQuantity">Minimum Quantity for an order to be included/</param>
        /// <returns>Returns a reference to the async task.</returns>
        public Task<ItemMarketOrders> GetMarketOrdersForItemType(
            int itemTypeId, 
            IEnumerable<int> includedRegions,
            int? systemId, 
            int minQuantity)
        {
            return Task<ItemMarketOrders>.Factory.TryRun(
                () =>
                {
                    string cacheKey;
                    IList<int> regionList = includedRegions != null ? includedRegions.ToList() : new List<int>();
                    if (systemId.HasValue)
                    {
                        cacheKey = CalcCacheKey(new[] { systemId.Value });
                    }
                    else if (includedRegions != null && regionList.Any())
                    {
                        cacheKey = CalcCacheKey(regionList);
                    }
                    else
                    {
                        cacheKey = CalcCacheKey(new[] { JitaSystemId });
                    }

                    CacheItem<ItemMarketOrders> cachedData =
                        _marketOrderCache.Get<ItemMarketOrders>(ItemKeyFormat.FormatInvariant(itemTypeId, cacheKey));
                    ItemMarketOrders itemData = null;
                    if (cachedData == null || cachedData.IsDirty)
                    {
                        // make the request for the types we don't have valid caches for
                        NameValueCollection requestParameters = CreateMarketRequestParameters(
                            new[] { itemTypeId },
                            regionList, 
                            systemId ?? 0, 
                            minQuantity);
                        Task<HttpResponseMessage> requestTask =
                            _requestProvider.PostAsync(new Uri(EveCentralBaseUrl + QuickLookApi), requestParameters);

                        requestTask.Wait(); // wait for the completion (we're in a background task anyways)

                        if (requestTask.IsCompleted && !requestTask.IsCanceled && !requestTask.IsFaulted &&
                            requestTask.Exception == null && requestTask.Result != null)
                        {
                            Task<Stream> contentStreamTask = requestTask.Result.Content.ReadAsStreamAsync();
                            contentStreamTask.Wait();
                            using (Stream stream = contentStreamTask.Result)
                            {
                                try
                                {
                                    // process result
                                    ItemMarketOrders data = GetMarketOrdersFromXml(stream);

                                    _marketOrderCache.Add(
                                        ItemKeyFormat.FormatInvariant(
                                            itemTypeId, 
                                            cacheKey), 
                                        data,
                                        DateTimeOffset.Now.Add(TimeSpan.FromHours(1)));

                                    itemData = data;
                                }
                                catch (Exception ex)
                                {
                                    Trace.TraceError(ex.FormatException());
                                    throw;
                                }
                            }
                        }
                        else
                        {
                            throw new InvalidOperationException(
                                "There was a problem requesting the market data.",
                                requestTask.Exception);
                        }
                    }

                    return itemData ?? (cachedData != null ? cachedData.Data : null);
                });
        }

        /// <summary>Gets a value indicating whether limited region selection.</summary>
        public bool LimitedRegionSelection
        {
            get { return false; }
        }

        /// <summary>Gets a value indicating whether limited system selection.</summary>
        public bool LimitedSystemSelection
        {
            get { return false; }
        }

        /// <summary>Gets the provider name.</summary>
        public string ProviderName
        {
            get { return Name; }
        }

        /// <summary>Gets the supported regions.</summary>
        public IEnumerable<int> SupportedRegions
        {
            get { return new int[0]; }
        }

        /// <summary>Gets the supported systems.</summary>
        public IEnumerable<int> SupportedSystems
        {
            get { return new int[0]; }
        }

        /// <summary>The get region based order stats.</summary>
        /// <param name="typeIds">The type ids.</param>
        /// <param name="includeRegions">Include these regions.</param>
        /// <param name="systemId">Use this system id to source the data (overrides region values).</param>
        /// <param name="minQuantity">The min quantity.</param>
        /// <returns>The <see cref="Task" />.</returns>
        /// <exception cref="Exception">Thrown when there's an XML exception</exception>
        /// <exception cref="InvalidOperationException">Thrown when there was a problem with the web request.</exception>
        public Task<IEnumerable<ItemOrderStats>> GetOrderStats(
            IEnumerable<int> typeIds, 
            IEnumerable<int> includeRegions,
            int? systemId, 
            int minQuantity)
        {
            return Task<IEnumerable<ItemOrderStats>>.Factory.TryRun(
                () =>
                {
                    var cachedItems = new List<ItemOrderStats>();
                    var typesToRequest = new List<int>();
                    string cacheKey;
                    var dirtyCache = new Dictionary<int, ItemOrderStats>();
                    includeRegions = includeRegions ?? new List<int>();
                    IList<int> regionList = includeRegions as IList<int> ?? includeRegions.ToList();
                    if (includeRegions != null)
                    {
                        regionList = includeRegions as IList<int> ?? includeRegions.ToList();
                    }
                    else
                    {
                        regionList = new List<int>();
                    }

                    if (systemId.HasValue)
                    {
                        cacheKey = CalcCacheKey(new[] { systemId.Value });
                    }
                    else if (includeRegions != null && regionList.Any())
                    {
                        cacheKey = CalcCacheKey(regionList);
                    }
                    else
                    {
                        cacheKey = CalcCacheKey(new[] { JitaSystemId });
                    }

                    foreach (int typeId in typeIds.Distinct())
                    {
                        CacheItem<ItemOrderStats> itemStats =
                            _regionDataCache.Get<ItemOrderStats>(ItemKeyFormat.FormatInvariant(typeId, cacheKey));
                        if (itemStats != null && itemStats.Data != null && !itemStats.IsDirty)
                        {
                            cachedItems.Add(itemStats.Data);
                        }
                        else
                        {
                            // queue for refresh
                            typesToRequest.Add(typeId);

                            // add to dirty cache incase of no data/error
                            if (itemStats != null && itemStats.IsDirty)
                            {
                                dirtyCache.Add(typeId, itemStats.Data);
                            }
                        }
                    }

                    if (typesToRequest.Any())
                    {
                        cachedItems.AddRange(
                            RetrieveItems(
                                typesToRequest, 
                                regionList, 
                                systemId ?? 0, 
                                minQuantity,
                                cacheKey));

                        // add in "dirty/expired" items as filler for items that didn't get downloaded or to smooth over loss of connection issues
                        foreach (
                            int itemKey in
                                dirtyCache.Keys.Where(itemKey => cachedItems.All(c => c.ItemTypeId != itemKey)))
                        {
                            cachedItems.Add(dirtyCache[itemKey]);
                        }

                        // TODO: log warning/error when task doesn't complete properly.
                    }

                    return cachedItems;
                });
        }

        /// <summary>Calculates the cache key to use.</summary>
        /// <param name="ids">The ids.</param>
        /// <returns>The <see cref="string" />.</returns>
        private static string CalcCacheKey(IEnumerable<int> ids)
        {
            return
                string.Join(string.Empty, ids.Select(id => id.ToInvariantString()).ToArray())
                    .GetHashCode()
                    .ToInvariantString();
        }

        /// <summary>The create market stat request.</summary>
        /// <param name="typesToRequest">The types to request.</param>
        /// <param name="regions">The regions.</param>
        /// <param name="systemId">The system id.</param>
        /// <param name="minQuantity">The min quantity.</param>
        /// <returns>The <see cref="Uri" />.</returns>
        private static NameValueCollection CreateMarketRequestParameters(
            IEnumerable<int> typesToRequest,
            IEnumerable<int> regions, 
            int systemId, 
            int minQuantity)
        {
            var parameters = new NameValueCollection();

            foreach (int type in typesToRequest)
            {
                parameters.Add(TypeId, type.ToInvariantString());
            }

            if (systemId == 0)
            {
                foreach (int region in regions)
                {
                    parameters.Add(RegionLimit, region.ToInvariantString());
                }
            }
            else
            {
                parameters.Add(UseSystem, systemId.ToInvariantString());
            }

            if (minQuantity > 1)
            {
                parameters.Add(MinQuantity, minQuantity.ToInvariantString());
            }

            return parameters;
        }

        /// <summary>Processes the order xml into individual order objects</summary>
        /// <param name="orderElement">The order element.</param>
        /// <param name="isBuyOrder">The is buy order.</param>
        /// <returns>The <see cref="IEnumerable" />.</returns>
        private static IEnumerable<MarketOrder> GetIndivdualOrders(XElement orderElement, bool isBuyOrder)
        {
            // ReSharper disable PossibleNullReferenceException
            // The format schema is strict and any exception is caught upstream.
            return from order in orderElement.Elements("order")
                let orderId = order.Attribute("id").Value.ToInt64()
                let regionId = order.Element("region").Value.ToInt32()
                let stationId = order.Element("station").Value.ToInt32()
                let stationName = order.Element("station_name").Value
                let security = order.Element("security").Value.ToDouble()
                let range = order.Element("range").Value.ToInt32()
                let price = order.Element("price").Value.ToDouble()
                let quantityRemaining = order.Element("vol_remain").Value.ToInt32()
                let minQuantity = order.Element("min_volume").Value.ToInt32()
                let expires = order.Element("expires").Value.ToDateTimeOffset(0)
                let reported = order.Element("reported_time").Value.ToDateTimeOffset(0)
                select
                    new MarketOrder
                    {
                        OrderId = orderId,
                        RegionId = regionId,
                        StationId = stationId,
                        StationName = stationName,
                        Security = security,
                        OrderRange = range,
                        Price = price,
                        QuantityRemaining = quantityRemaining,
                        MinQuantity = minQuantity,
                        Expires = expires,
                        Freshness = reported,
                        IsBuyOrder = isBuyOrder
                    };

            // ReSharper restore PossibleNullReferenceException
        }

        /// <summary>The get order stats from xml.</summary>
        /// <param name="stream">The stream.</param>
        /// <returns>The market orders object.</returns>
        private static ItemMarketOrders GetMarketOrdersFromXml(Stream stream)
        {
            var orderData = new ItemMarketOrders();

            using (TextReader reader = new StreamReader(stream))
            {
                XDocument xml = XDocument.Load(reader);

                // ReSharper disable PossibleNullReferenceException
                XElement dataElement = xml.Root.Element("quicklook");

                if (dataElement != null)
                {
                    orderData.ItemTypeId = dataElement.Element("item").Value.ToInt32();
                    orderData.ItemName = dataElement.Element("itemname").Value;
                    orderData.Regions =
                        new HashSet<int>(
                            dataElement.Element("regions")
                                .Value.Split(',')
                                .Select(region => region.ToInt32())
                                .Where(region => region > 0));
                    orderData.Hours = dataElement.Element("hours").Value.ToInt32();
                    orderData.MinQuantity = dataElement.Element("minqty").Value.ToInt32();

                    // sell orders
                    XElement orderElement;
                    if ((orderElement = dataElement.Element("sell_orders")) != null)
                    {
                        orderData.SellOrders = GetIndivdualOrders(orderElement, false).ToList();
                    }

                    // buy orders
                    if ((orderElement = dataElement.Element("buy_orders")) != null)
                    {
                        orderData.BuyOrders = GetIndivdualOrders(orderElement, true).ToList();
                    }
                }
            }

            // ReSharper restore PossibleNullReferenceException
            return orderData;
        }

        /// <summary>The get order data.</summary>
        /// <param name="element">The element.</param>
        /// <returns>The <see cref="OrderStats" />.</returns>
        private static OrderStats GetOrderData(XElement element)
        {
            // ReSharper disable PossibleNullReferenceException
            // null exceptions are caught further up the call stack.
            long volume = element.Element("volume").Value.ToInt64();

            double avg = element.Element("avg").Value.ToDouble();
            double max = element.Element("max").Value.ToDouble();
            double min = element.Element("min").Value.ToDouble();
            double stddev = element.Element("stddev").Value.ToDouble();
            double median = element.Element("median").Value.ToDouble();
            double percentile = element.Element("percentile").Value.ToDouble();

            return new OrderStats
            {
                Volume = volume,
                Average = avg,
                Maximum = max,
                Minimum = min,
                StdDeviation = stddev,
                Median = median,
                Percentile = percentile
            };

            // ReSharper restore PossibleNullReferenceException
        }

        /// <summary>The get order stats from xml.</summary>
        /// <param name="stream">The stream.</param>
        /// <returns>The collection of item order stats.</returns>
        private static IEnumerable<ItemOrderStats> GetOrderStatsFromXml(Stream stream)
        {
            IEnumerable<ItemOrderStats> orderStats = null;
            using (TextReader reader = new StreamReader(stream))
            {
                // ReSharper disable PossibleNullReferenceException
                XDocument xml;
                try
                {
                    xml = XDocument.Load(reader);
                }
                catch (Exception e)
                {
                    orderStats = new List<ItemOrderStats>();
                    return orderStats;

                }
                if (xml.Root != null && xml.Root.Element("marketstat") != null)
                {
                    orderStats = from stats in xml.Root.Elements("marketstat")
                        from type in stats.Elements("type")
                        let typeId = type.Attribute("id").Value.ToInt32()
                        let buyData = GetOrderData(type.Element("buy"))
                        let sellData = GetOrderData(type.Element("sell"))
                        let allData = GetOrderData(type.Element("all"))
                        select new ItemOrderStats { ItemTypeId = typeId, Buy = buyData, Sell = sellData, All = allData };
                }

                // ReSharper restore PossibleNullReferenceException
            }

            return orderStats;
        }

        /// <summary>The retrieve items.</summary>
        /// <param name="typesToRequest">The types to request.</param>
        /// <param name="includeRegions">The include regions.</param>
        /// <param name="systemId">The system id.</param>
        /// <param name="minQuantity">The min quantity.</param>
        /// <param name="cacheKey">The cache key.</param>
        /// <returns>The <see cref="IEnumerable" />.</returns>
        private IEnumerable<ItemOrderStats> RetrieveItems(
            List<int> typesToRequest, 
            IEnumerable<int> includeRegions,
            int systemId, 
            int minQuantity, 
            string cacheKey)
        {
            var resultItems = new List<ItemOrderStats>();

	        if (!_isServiceAvailable)
	        {
		        return resultItems;
	        }

            // make the request for the types we don't have valid caches for
            NameValueCollection requestParameters = CreateMarketRequestParameters(
                typesToRequest, 
                includeRegions,
                systemId, 
                minQuantity);

            Task<HttpResponseMessage> requestTask =
                _requestProvider.PostAsync(new Uri(EveCentralBaseUrl + MarketStatApi), requestParameters);

	        requestTask.Wait(); // wait for the completion (we're in a background task anyways)
	        if (!requestTask.Result.IsSuccessStatusCode || WebServiceExceptionHelper.IsServiceUnabailableError(requestTask.Exception))
	        {
		        _isServiceAvailable = false;
				return resultItems;
	        }

			if (requestTask.IsCompleted && requestTask.Result != null && !requestTask.IsCanceled &&
                !requestTask.IsFaulted && requestTask.Exception == null)
            {
                Task<Stream> contentStreamTask = requestTask.Result.Content.ReadAsStreamAsync();
                contentStreamTask.Wait();

                using (Stream stream = contentStreamTask.Result)
                {
                    try
                    {
                        // process result
                        IEnumerable<ItemOrderStats> retrievedItems = GetOrderStatsFromXml(stream);

                        // cache it.
                        foreach (ItemOrderStats item in retrievedItems)
                        {
                            _regionDataCache.Add(
                                ItemKeyFormat.FormatInvariant(item.ItemTypeId, cacheKey), 
                                item,
                                DateTimeOffset.Now.Add(_cacheTtl));
                            resultItems.Add(item);
                            _regionDataCache.Add(
                                ItemKeyFormat.FormatInvariant(item.ItemTypeId, cacheKey), 
                                item,
                                DateTimeOffset.Now.Add(_cacheTtl));
                            resultItems.Add(item);
                        }
                    }
                    catch (Exception ex)
                    {
                        Trace.TraceError(ex.FormatException());
                        throw;
                    }
                }
            }

            return resultItems;
        }

		private static bool _isServiceAvailable = true;
    }
}