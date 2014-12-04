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
        private bool isDisposed;

        /// <summary>
        /// Creates an HttpClient to access New Relic rest API in strongly typed manner
        /// </summary>
        /// <param name="newRelicApiKey">Api key to be added to "x-api-key" header</param>
        public NewRelicAccessor(string newRelicApiKey)
        {
            newRelicConnector = new NewRelicConnector(newRelicApiKey);
        }

        /// <summary>
        /// Posts data to New Relic rest API
        /// </summary>
        /// <param name="postCommand"></param>
        /// <typeparam name="TItem"></typeparam>
        /// <returns></returns>
        public HttpResponseMessage Post<TItem>(PostCommandBase<TItem> postCommand) where TItem : class
        {
            return newRelicConnector.PostData(postCommand.Query, postCommand.Item.ToString());
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
