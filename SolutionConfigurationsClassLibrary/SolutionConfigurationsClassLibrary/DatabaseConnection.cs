using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionConfigurationsClassLibrary
{
    public class DatabaseConnection
    {
        protected string databaseName;

        public DatabaseConnection(IExternalDataAccessSettings settings)
        {
            databaseName = settings.getDatabaseName();
        }

        public void connect()
        {
            Console.WriteLine("Just connected to " + this.databaseName + " database!");
        }

        public int getValueToUseForCalculation()
        {
            int value = 0;

            if (this.databaseName == "TEST")
                value = 5;
            else if (this.databaseName == "PROD")
                value = 10;

            return value;
        }
    }



}
