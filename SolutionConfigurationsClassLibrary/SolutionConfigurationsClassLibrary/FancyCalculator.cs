using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionConfigurationsClassLibrary
{
    public class FancyCalculator
    {
        protected DatabaseConnection dbConn;
        protected WebServiceClient wsClient;
        protected bool logToConsole;

        /// <summary>
        /// Construct FancyCalculator. If required dependencies are not provided in constructor,
        /// then they are created from within class.
        /// </summary>
        /// <param name="dbConn"></param>
        /// <param name="wsClient"></param>
        public FancyCalculator(DatabaseConnection dbConn, WebServiceClient wsClient, bool logToConsole)
        {
            if (dbConn == null)
                dbConn = this.getDefaultDatabaseConnection();

            if (wsClient == null)
                wsClient = this.getDefaultWebServiceClient();

            this.dbConn = dbConn;
            this.wsClient = wsClient;
            this.logToConsole = logToConsole;
        }

        public int DoFancyStuffWithANumber(int aNumber, bool reportToWebService)
        {
            var multiplier = this.getMultiplierValueFromDatabase();
            var result = this.makeCalculation(multiplier);
            this.reportResultsToWebService(result);

            return result;
        }

        protected int getMultiplierValueFromDatabase()
        {
            var status = this.dbConn.connect();

            if (this.logToConsole)
                Console.WriteLine("Just connected to " + status + " database!");

            return this.dbConn.getValueToUseForCalculation();
        }

        protected int makeCalculation(int multiplierValue)
        {
            int result = multiplierValue * 10;
            return result;
        }

        protected void reportResultsToWebService(int result)
        {
            var status = this.wsClient.sendMessage("Result of FancyCalculator: " + result.ToString());

            if (this.logToConsole)
                Console.WriteLine(status);
        }

        protected DatabaseConnection getDefaultDatabaseConnection()
        {
            var dbConn = new DatabaseConnection();
            return dbConn;
        }

        protected WebServiceClient getDefaultWebServiceClient()
        {
            var wsClient = new WebServiceClient();
            return wsClient;
        }
    }
}
