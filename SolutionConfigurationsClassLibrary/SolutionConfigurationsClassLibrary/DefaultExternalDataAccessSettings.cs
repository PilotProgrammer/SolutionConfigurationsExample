using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace SolutionConfigurationsClassLibrary
{
    public class DefaultExternalDataAccessSettings : IExternalDataAccessSettings
    {
        public virtual string DatabaseName
        {
            get
            {
                string databaseName = null;
                var connectionName = "SolutionConfigurationsClassLibrary.Properties.Settings.PrimaryDatabase";

                if (ConfigurationManager.ConnectionStrings[connectionName] != null)
                    databaseName = ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
                else
                    throw new Exception("Client solution must define connection for " + connectionName);
                return databaseName;
            }
        }

        public virtual string WebServiceUrl
        {
            get
            {
                var webserviceUrl = Properties.Settings.Default.PrimaryWebService;

                if (webserviceUrl == null || (webserviceUrl == "NOT_DEFINED"))
                    throw new Exception("Client solution must define web service url");

                return webserviceUrl;
            }
        }
    }
}
