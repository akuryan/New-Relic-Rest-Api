namespace NewRelicSharp.Constants
{
    /// <summary>
    /// Used to store constant values
    /// </summary>
    public static class RestApiConstants
    {
        /// <summary>
        /// Rest API root 
        /// </summary>
        public const string ApiRootV1 = "api/v1/";

        public const string ApiRootV2 = "v2/";

        public const string Agents = "agents";

        public const string Applications = "applications";

        public const string Metrics = "metrics";

        public const string DataFormatJSon = "json";

        public const string DataFormatXML = "xml";

        /// <summary>
        /// Deployments.xml is outstanding query
        /// </summary>
        public const string DeploymentsUri = "deployments.xml";

        /// <summary>
        /// 
        /// </summary>
        public const string NewRelicHttpsUrl = "https://api.newrelic.com/";
    }
}
