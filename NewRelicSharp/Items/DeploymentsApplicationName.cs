namespace NewRelicSharp.Items
{
    using System;
    using System.Text;

    /// <summary>
    /// Represents deployment record for deployment, being recorded with Application Name
    /// Is not recommended, IMHO
    /// </summary>
    public class DeploymentsApplicationName : DeploymentsBase
    {
        /// <summary>
        /// Application name for which deployment is held
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string App_Name { get; set; }

        public override string ToString()
        {
            var data = new StringBuilder(base.ToString());

            if (string.IsNullOrWhiteSpace(App_Name))
            {
                throw new ArgumentNullException("App_Name could not be empty" + " in this type of deployments recorder", "Argument"); 
            }

            data.AppendFormat(DeploymentInformationFormat, "app_name", this.App_Name);
            return data.ToString();
        }
    }
}
