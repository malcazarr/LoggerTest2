using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerTest2.Class
{
    class AllDestination : ILogger
    {
        void ILogger.write(string message, string type)
        {
            sender(message, type);
        }

        public void sender(string message, string type)
        {
            var logConsole = new Logger(new LoggerConsole());
            var logFile = new Logger(LoggerFile.Instance);
            var logDatabase = new Logger(new LoggerDatabases());
            switch (type){
                case "WARN":
                    logConsole.WARN(message);
                    logFile.WARN(message);
                    logDatabase.WARN(message);
                    break;
                case "INFO":
                    logConsole.INFO(message);
                    logFile.INFO(message);
                    logDatabase.INFO(message);
                    break;
                case "MESSAGE":
                    logConsole.MESSAGE(message);
                    logFile.MESSAGE(message);
                    logDatabase.MESSAGE(message);
                    break;
                case "ERROR":
                    logConsole.ERROR(message);
                    logFile.ERROR(message);
                    logDatabase.ERROR(message);
                    break;
            }

        }
    }
}
