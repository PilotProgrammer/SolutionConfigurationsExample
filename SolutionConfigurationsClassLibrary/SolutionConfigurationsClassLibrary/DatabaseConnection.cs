using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionConfigurationsClassLibrary
{
    public class DatabaseConnection
    {
        public string connect()
        {
            string connectionType = null;
#if DEBUG
            connectionType = "TEST";
#else
            connectionType = "PROD";
#endif
            return connectionType;
        }

        public int getValueToUseForCalculation()
        {
            int value;
#if DEBUG
            value = 5;
#else
            value = 10;
#endif
            return value;
        }
    }
}
