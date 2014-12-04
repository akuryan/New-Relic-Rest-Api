namespace NewRelicSharp.Commands.Post
{
    using System;

    using NewRelicSharp.Constants;

    /// <summary>
    /// Base for all POST commands
    /// </summary>
    /// <typeparam name="TItem"></typeparam>
    public abstract class PostCommandBase<TItem> where TItem : class
    {
        /// <summary>
        /// Query to execute (without API root)
        /// </summary>
        public abstract string InitialQuery { get; }
        
        /// <summary>
        /// Query to be executed
        /// </summary>
        public string Query
        {
            get
            {
                //as deployments.xml is somewhat outstanding - we should inlcude it here
                return this.InitialQuery.Equals(RestApiConstants.DeploymentsUri, StringComparison.OrdinalIgnoreCase) 
                    ? 
                    RestApiConstants.DeploymentsUri 
                    : 
                    string.Concat(RestApiConstants.ApiRoot, this.InitialQuery);
            }
        }

        /// <summary>
        /// Class to be posted
        /// </summary>
        public TItem Item { get; set; }
    }
}