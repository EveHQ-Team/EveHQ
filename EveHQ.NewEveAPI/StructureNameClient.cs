// Проект: EveHQ.NewEveAPI
// Имя файла: StructureNameClient.cs
// GUID файла: 7B211018-BF5F-4D4C-9F13-B6636F134EE0
// Автор: Mike Eshva (mike@eshva.ru)
// Дата создания: 11.08.2017

#region Usings

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using EveHQ.Caching;
using EveHQ.Common;
using EveHQ.Common.Extensions;
using EveHQ.EveData;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

#endregion


namespace EveHQ.NewEveApi
{
	public sealed class StructureNameClient
	{
		public StructureNameClient(ICacheProvider cacheProvider, IHttpRequestProvider httpRequestProvider)
		{
			_cacheProvider = cacheProvider;
			_httpRequestProvider = httpRequestProvider;
		}

		public Task<EveServiceResponse<EveStructure>> GetStructureNameAsync(long locationId)
		{
			Uri requestUri;
			Uri.TryCreate(StructureNameApiLocation + locationId, UriKind.Absolute, out requestUri);
			var cacheKey = CacheKeyFormat.FormatInvariant(locationId);

			var resultData = GetCacheEntry<EveStructure>(cacheKey);

			return resultData != null && !resultData.IsDirty && resultData.Data.IsSuccess
				? ReturnCachedResponse(resultData)
				: _httpRequestProvider.GetAsync(requestUri).ContinueWith(webTask => ProcessServiceResponse(webTask, cacheKey, 600));
		}

		private EveServiceResponse<EveStructure> ProcessServiceResponse(
			Task<HttpResponseMessage> webTask,
			string cacheKey,
			int defaultCacheSeconds)
		{
			var cacheTime = DateTimeOffset.Now.AddSeconds(defaultCacheSeconds);
			var jsonFromResponse = GetJsonFromResponse(webTask.Result);
			var jObject = JObject.Parse(jsonFromResponse);
			if (jObject.Count == 0)
			{
				return new EveServiceResponse<EveStructure>
						{
							ServiceException = new Exception("Not found."),
							IsSuccessfulHttpStatus = false,
							HttpStatusCode = HttpStatusCode.NotFound,
							CacheUntil = cacheTime
						};
			}

			var result = GetStructureDataFromJson(jsonFromResponse, webTask.Result.StatusCode, cacheTime);
			SetCacheEntry(cacheKey, result);
			return result;
		}

		private static EveServiceResponse<EveStructure> GetStructureDataFromJson(
			string response,
			HttpStatusCode responseStatusCode,
			DateTimeOffset cacheTime)
		{
			var structureData = JsonConvert.DeserializeObject<Dictionary<long, JToken>>(response);
			var structureProperties = structureData.Values.First();
			var structure = new EveStructure
							{
								StructureId = structureData.Keys.First(),
								StructureName = structureProperties["name"].Value<string>(),
								StructureTypeId = structureProperties["typeId"].Value<int>(),
								StructureTypeName = structureProperties["typeName"].Value<string>(),
								IsPublic = structureProperties["public"].Value<bool>(),
								RegionId = structureProperties["regionId"].Value<int>(),
								RegionName = structureProperties["regionName"].Value<string>(),
								SystemId = structureProperties["systemId"].Value<int>(),
								SystemName = structureProperties["systemName"].Value<string>()
							};

			var result = new EveServiceResponse<EveStructure>
						{
							ResultData = structure,
							ServiceException = null,
							IsSuccessfulHttpStatus = true,
							HttpStatusCode = responseStatusCode,
							CacheUntil = cacheTime
						};
			return result;
		}

		private void SetCacheEntry(string key, EveServiceResponse<EveStructure> data)
		{
			_cacheProvider.Add(key, data, data.CacheUntil);
		}

		private static string GetJsonFromResponse(HttpResponseMessage message)
		{
			var readTask = message.Content.ReadAsStringAsync();
			readTask.Wait();
			var content = readTask.Result;
			return content;
		}

		private CacheItem<EveServiceResponse<T>> GetCacheEntry<T>(string key) where T : class => _cacheProvider.Get<EveServiceResponse<T>>(key);

		private static Task<EveServiceResponse<T>> ReturnCachedResponse<T>(CacheItem<EveServiceResponse<T>> cachedResult) where T : class
		{
			cachedResult.Data.CachedResponse = true;
			return Task.Factory.StartNew(() => cachedResult.Data);
		}

		private readonly ICacheProvider _cacheProvider;
		private readonly IHttpRequestProvider _httpRequestProvider;
		private const string CacheKeyFormat = "EveStructureKey_{0}";
		private const string StructureNameApiLocation = "https://stop.hammerti.me.uk/api/citadel/";
	}
}