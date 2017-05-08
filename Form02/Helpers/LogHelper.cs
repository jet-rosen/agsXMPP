using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form02.Helpers
{
    class LogHelper
    {
        public static string LOG_TAG = "DEVELOPER __ ";


        public static void LogConsole(string logs)
        {
            System.Console.WriteLine(LOG_TAG + logs);
        }

        public static void LogConsole(string logType, string logs)
        {
            System.Console.WriteLine(logType + " __ " + logs);
        }
    }
}
