namespace NewRelicSharp
{
    using System;

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
