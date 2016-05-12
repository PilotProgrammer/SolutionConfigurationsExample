using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionConfigurationsClassLibrary
{
    public class DatabaseConnection
    {
        protected string DatabaseName;

        public DatabaseConnection(IExternalDataAccessSettings settings)
        {
            this.DatabaseName = settings.DatabaseName;
        }

        public DatabaseConnection()
            : this(new DefaultExternalDataAccessSettings())
        { }

        public void Connect()
        {
            Console.WriteLine("Just connected to " + this.DatabaseName + " database!");
        }

        public int GetValueToUseForCalculation()
        {
            int value = 0;

            if (this.DatabaseName == "TEST")
                value = 5;
            else if (this.DatabaseName == "PROD")
                value = 10;

            return value;
        }
    }



}
