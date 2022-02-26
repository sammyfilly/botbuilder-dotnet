﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Net.Http;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace Microsoft.Bot.Connector.Client.Authentication
{
    /// <summary>
    /// HttpClientFactory that always returns the same HttpClient instance for ADAL AcquireTokenAsync calls.
    /// </summary>
    internal class ConstantHttpClientFactory : Microsoft.IdentityModel.Clients.ActiveDirectory.IHttpClientFactory
    {
        private readonly HttpClient _httpClient;

        public ConstantHttpClientFactory(HttpClient client)
        {
            _httpClient = client ?? throw new ArgumentNullException(nameof(client));
        }

        public HttpClient GetHttpClient()
        {
            return _httpClient;
        }
    }
}
