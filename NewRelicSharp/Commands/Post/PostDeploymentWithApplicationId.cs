namespace NewRelicSharp.Commands.Post
{
    using NewRelicSharp.Constants;
    using NewRelicSharp.Items;

    /// <summary>
    /// Inform New Relic about deployment, using application ID
    /// </summary>
    public class PostDeploymentWithApplicationId : PostCommandBase
    {
        public override string GetContent()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Provides query to post to
        /// </summary>
        public override string InitialQuery
        {
            get
            {
                return RestApiConstants.DeploymentsUri;
            }
        }
    }
}
