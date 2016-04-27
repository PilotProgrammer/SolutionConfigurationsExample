using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionConfigurationsClassLibrary
{
    public interface IExternalDataAccessSettings
    {
        string GetDatabaseName();
        string GetWebServiceUrl();
    }
}
