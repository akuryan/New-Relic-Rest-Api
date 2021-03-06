﻿using NewRelicSharp.Constants;

namespace NewRelicSharp
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    using System.Web;

    /// <summary>
    /// Disposable connector for New Relic rest api
    /// </summary>
    public class NewRelicConnector : IDisposable
    {
        private readonly HttpClient httpClient;
        private readonly string newRelicDomainUrl;
        private readonly string newRelicApiKey;
        private bool isDisposed;

        /// <summary>
        /// Creates httpclient to access new relic api with domain url already built-in
        /// </summary>
        /// <param name="config"></param>
        public NewRelicConnector(NewRelicConfiguration config)
        {
            httpClient = new HttpClient();
            newRelicApiKey = config.ApiKey;
            newRelicDomainUrl = RestApiConstants.NewRelicHttpsUrl;
        }


        public void Dispose()
        {
            if (this.httpClient == null || isDisposed)
            {
                return;
            }

            this.httpClient.Dispose();
            this.isDisposed = true;
        }

        /// <summary>
        /// Posts Data to New relic, using HTTP Client
        /// </summary>
        /// <param name="query">URI to post data to</param>
        /// <param name="data">Data to post to</param>
        /// <returns>Returns <see cref="HttpResponseMessage"/> for Posted data</returns>
        public HttpResponseMessage PostData(string query, string data)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            var postUrl = this.EnsureFullUrl(query);
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, postUrl);

            var content = new StringContent(data, Encoding.UTF8, "application/x-www-form-urlencoded");
            requestMessage.Content = content;
            requestMessage.Headers.Add("x-api-key", newRelicApiKey);
            requestMessage.Headers.Add("Accept", "text/xml");
            httpClient.DefaultRequestHeaders.Add("x-api-key", newRelicApiKey);
            httpClient.DefaultRequestHeaders.Add("Accept", "text/xml");
            return httpClient.PostAsync(postUrl, content).Result;
        }

        public HttpResponseMessage GetData(string query)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            var getUrl = this.EnsureFullUrl(query);
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, getUrl);

            requestMessage.Headers.Add("x-api-key", newRelicApiKey);
            requestMessage.Headers.Add("Accept", "text/xml");
            httpClient.DefaultRequestHeaders.Add("x-api-key", newRelicApiKey);
            httpClient.DefaultRequestHeaders.Add("Accept", "text/xml");
            return httpClient.GetAsync(getUrl).Result;
        }

        private string EnsureFullUrl(string query)
        {
            if (!query.StartsWith(newRelicDomainUrl))
            {
                query = VirtualPathUtility.AppendTrailingSlash(newRelicDomainUrl) + query.TrimStart('/');
            }
            return query;
        }
    }
}
