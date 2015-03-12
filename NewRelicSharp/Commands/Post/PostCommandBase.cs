using System.Net.Http;

namespace NewRelicSharp.Commands.Post
{
    using System;

    using NewRelicSharp.Constants;

    /// <summary>
    /// Base for all POST commands
    /// </summary>
    public abstract class PostCommandBase : ApiCommandBase
    {
        public override string GetQuery()
        {
            //as deployments.xml is somewhat outstanding - we should inlcude it here
            return this.InitialQuery.Equals(RestApiConstants.DeploymentsUri, StringComparison.OrdinalIgnoreCase)
                ?
                RestApiConstants.DeploymentsUri
                :
                string.Concat(RestApiConstants.ApiRootV1, this.InitialQuery);
        }

        public override abstract string GetContent();

        /// <summary>
        /// Query to execute (without API root)
        /// </summary>
        public abstract string InitialQuery { get; }

        public override HttpMethod Method
        {
            get { return HttpMethod.Post; }
        }
    }
}