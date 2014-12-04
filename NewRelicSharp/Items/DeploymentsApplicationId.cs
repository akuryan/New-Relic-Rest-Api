namespace NewRelicSharp.Items
{
    using System;
    using System.Text;

    /// <summary>
    /// Represents deployment record for deployment, being recorded with Application Id
    /// </summary>
    public class DeploymentsApplicationId : DeploymentsBase
    {
        /// <summary>
        /// Application id for which deployment is held
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string Application_Id { get; set; }

        public override string ToString()
        {
            var data = new StringBuilder(base.ToString());

            if (string.IsNullOrWhiteSpace(Application_Id))
            {
                throw new ArgumentNullException("Application_Id could not be empty" + " in this type of deployments recorder", "Argument");
            }

            data.AppendFormat(DeploymentInformationFormat, "application_id", this.Application_Id);
            return data.ToString();
        }
    }
}
