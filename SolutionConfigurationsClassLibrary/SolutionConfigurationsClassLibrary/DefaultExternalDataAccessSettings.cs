using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace SolutionConfigurationsClassLibrary
{
    class DefaultExternalDataAccessSettings : IExternalDataAccessSettings
    {
        public string DatabaseName
        {
            get
            {
                var databaseName = ConfigurationManager.ConnectionStrings["SolutionConfigurationsClassLibrary.Properties.Settings.PrimaryDatabase"].ConnectionString;
                return databaseName;
            }
        }

        public string WebServiceUrl
        {
            get
            {
                var webserviceUrl = Properties.Settings.Default.PrimaryWebService;
                return webserviceUrl;
            }
        }
    }
}
