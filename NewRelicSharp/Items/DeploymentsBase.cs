namespace NewRelicSharp.Items
{
    using System.Text;

    /// <summary>
    /// Represents base, not mandatory parameters for deployments.
    /// Could not be used to record deployment
    /// Do not use this base class directly
    /// </summary>
    public abstract class DeploymentsBase
    {
        internal const string DeploymentInformationFormat = "deployment[{0}]={1}&";

        /// <summary>
        /// A list of changes for this deployment
        /// </summary>
        public string Changelog { get; set; }

        /// <summary>
        ///  Text annotation for the deployment; notes for you
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// A revision number (e.g., git commit SHA)
        /// </summary>
        public string Revision { get; set; }

        /// <summary>
        /// The name of the user/process that triggered this deployment
        /// </summary>
        public string User { get; set; }

        /// <summary>
        ///  Name of the application
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// The environment for this deployment
        /// </summary>
        public string Environment { get; set; }

        /// <summary>
        /// Returns string representation for current deployment
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var data = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(this.Changelog))
            {
                data.AppendFormat(DeploymentInformationFormat, "changelog", this.Changelog);
            }

            if (!string.IsNullOrWhiteSpace(this.Description))
            {
                data.AppendFormat(DeploymentInformationFormat, "description", this.Description);
            }

            if (!string.IsNullOrWhiteSpace(this.Revision))
            {
                data.AppendFormat(DeploymentInformationFormat, "revision", this.Revision);
            }

            if (!string.IsNullOrWhiteSpace(this.User))
            {
                data.AppendFormat(DeploymentInformationFormat, "user", this.User);
            }

            if (!string.IsNullOrWhiteSpace(this.AppName))
            {
                data.AppendFormat(DeploymentInformationFormat, "appname", this.AppName);
            }

            if (!string.IsNullOrWhiteSpace(this.AppName))
            {
                data.AppendFormat(DeploymentInformationFormat, "appname", this.AppName);
            }

            if (!string.IsNullOrWhiteSpace(this.Environment))
            {
                data.AppendFormat(DeploymentInformationFormat, "environment", this.Environment);
            }

            return data.ToString().TrimEnd('&');
        }
    }
}
