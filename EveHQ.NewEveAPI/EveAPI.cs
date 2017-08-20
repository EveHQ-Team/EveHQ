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
// ==============================================================================

using System;
using EveHQ.Caching;
using EveHQ.Common;

namespace EveHQ.NewEveApi
{
    /// <summary>The eve api.</summary>
    public sealed class EveAPI : IDisposable
    {
        /// <summary>The _cache provider.</summary>
        private readonly ICacheProvider _cacheProvider;

        /// <summary>The _request provider.</summary>
        private readonly IHttpRequestProvider _requestProvider;

        /// <summary>The _service location.</summary>
        private readonly string _serviceLocation;

        /// <summary>The _account client.</summary>
        private AccountClient _accountClient;

        /// <summary>The _character client.</summary>
        private CharacterClient _characterClient;

        /// <summary>The _corp client.</summary>
        private CorpClient _corpClient;

        private EveClient _eveClient;

        private ServerClient _serverClient;
	    private StructureNameClient _structureName;

	    /// <summary>Initializes a new instance of the <see cref="EveAPI" /> class.</summary>
        /// <param name="dataCacheFolder">The data cache folder.</param>
        /// <param name="requestProvider"></param>
        public EveAPI(string dataCacheFolder, IHttpRequestProvider requestProvider)
            : this(
                BaseApiClient.DefaultEveWebServiceLocation, new TextFileCacheProvider(dataCacheFolder), requestProvider)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="EveAPI" /> class.</summary>
        /// <param name="apiServiceLocation"></param>
        /// <param name="dataCacheFolder">The data cache folder.</param>
        /// <param name="requestProvider"></param>
        public EveAPI(string apiServiceLocation, string dataCacheFolder, IHttpRequestProvider requestProvider)
            : this(apiServiceLocation, new TextFileCacheProvider(dataCacheFolder), requestProvider)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="EveAPI" /> class.</summary>
        /// <param name="eveWebServiceLocation">The eve web service location.</param>
        /// <param name="cacheProvider">The cache provider.</param>
        /// <param name="requestProvider">The request provider.</param>
        public EveAPI(string eveWebServiceLocation, ICacheProvider cacheProvider, IHttpRequestProvider requestProvider)
        {
            _serviceLocation = eveWebServiceLocation;
            _cacheProvider = cacheProvider;
            _requestProvider = requestProvider;
        }

        /// <summary>Gets a client instance for interacting with the Account related service methods</summary>
        public AccountClient Account
        {
            get
            {
                return _accountClient ??
                       (_accountClient = new AccountClient(_serviceLocation, _cacheProvider, _requestProvider));
            }
        }

        /// <summary>Gets a client instance for interacting with the Character related service methods</summary>
        public CharacterClient Character
        {
            get
            {
                return _characterClient ??
                       (_characterClient = new CharacterClient(_serviceLocation, _cacheProvider, _requestProvider));
            }
        }

        /// <summary>Gets a client instance for interacting with the Corporation related service methods</summary>
        public CorpClient Corporation
        {
            get
            {
                return _corpClient ?? (_corpClient = new CorpClient(_serviceLocation, _cacheProvider, _requestProvider));
            }
        }

        public EveClient Eve
        {
            get
            {
                return _eveClient ?? (_eveClient = new EveClient(_serviceLocation, _cacheProvider, _requestProvider));
            }
        }

        public ServerClient Server
        {
            get
            {
                return _serverClient ??
                       (_serverClient = new ServerClient(_serviceLocation, _cacheProvider, _requestProvider));
            }
        }

	    public StructureNameClient StructureName => _structureName ?? (_structureName = new StructureNameClient(_cacheProvider, _requestProvider));

	    public void Dispose()
        {
            if (_accountClient != null)
            {
                _accountClient.Dispose();
            }

            if (_characterClient != null)
            {
                _characterClient.Dispose();
            }

            if (_corpClient != null)
            {
                _corpClient.Dispose();
            }

            if (_eveClient != null)
            {
                _eveClient.Dispose();
            }

            if (_serverClient != null)
            {
                _serverClient.Dispose();
            }
        }
    }
}