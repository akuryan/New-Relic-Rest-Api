using System.Collections.Generic;
using System.Xml.Serialization;
using NewRelicSharp.Commands;
using NewRelicSharp.Items;

namespace NewRelicSharp
{
    using System;
    using System.IO;
    using System.Net.Http;

    using NewRelicSharp.Commands.Post;

    /// <summary>
    /// Used to access New Relic using custom classes
    /// </summary>
    public class NewRelicAccessor : IDisposable
    {
        private readonly NewRelicConnector newRelicConnector;
        private readonly IApiCommandBuilder apiCommandBuilder;
        private bool isDisposed;

        /// <summary>
        /// Creates an HttpClient to access New Relic rest API in strongly typed manner
        /// </summary>
        /// <param name="configuration"></param>
        public NewRelicAccessor(NewRelicConfiguration configuration, IApiCommandBuilder apiCommandBuilder)
        {
            newRelicConnector = new NewRelicConnector(configuration);
            this.apiCommandBuilder = apiCommandBuilder;
        }

        public Metrics GetMetricNames()
        {
            Metrics result;

            var command = apiCommandBuilder.CreateGetMetricNames();

            var response = Run(command);

            var content = response.Content.ReadAsStringAsync();

            using (var sr = new StringReader(content.Result))
            {
                var serializer = new XmlSerializer(typeof(Metrics));
                result = (Metrics)serializer.Deserialize(sr);
            }

            return result;
        }

        public ApplicationsResponse GetApplicationIds()
        {
            ApplicationsResponse result;

            var command = apiCommandBuilder.CreateGetApplicationIds();

            var response = Run(command);

            var content = response.Content.ReadAsStringAsync();

            using (var sr = new StringReader(content.Result))
            {
                var serializer = new XmlSerializer(typeof(ApplicationsResponse));
                result = (ApplicationsResponse)serializer.Deserialize(sr);
            }

            return result;
            
        }

        /// <summary>
        /// Send data to New Relic rest API
        /// </summary>
        /// <param name="apiCommand"></param>
        /// <returns></returns>
        private HttpResponseMessage Run(IApiCommand apiCommand)
        {
            switch (apiCommand.Method.Method)
            {
                case "GET":
                    return newRelicConnector.GetData(apiCommand.GetQuery());
                case "POST":
                    return newRelicConnector.PostData(apiCommand.GetQuery(), apiCommand.GetContent());
            }

            throw new NotSupportedException(String.Format("HTTM method '{0}' is not supported", apiCommand.Method.Method));
        }

        public void Dispose()
        {
            if (isDisposed)
            {
                return;
            }
            this.newRelicConnector.Dispose();
            this.isDisposed = true;
        }
    }
}
