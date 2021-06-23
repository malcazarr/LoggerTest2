using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerTest2.Class
{
    enum typeDestination { file, console, database, all } 
    class Logger
    {
        private ILogger iLogger;
        public Logger(ILogger iLogger)
        {
            this.iLogger = iLogger;
        }

        public Logger(typeDestination type)
        {
            switch (type)
            {
                case typeDestination.file:
                    iLogger = LoggerFile.Instance;
                    break;
                case typeDestination.console:
                    iLogger = new LoggerConsole();
                    break;
                case typeDestination.database:
                    iLogger = new LoggerDatabases();
                    break;
                case typeDestination.all:
                    iLogger = new AllDestination();
                    break;
            }
        }

        public void WARN(string message)
        {
            iLogger.write(message, "WARN");
        }

        public void INFO (string message)
        {
            iLogger.write(message, "INFO");
        }

        public void MESSAGE (string message)
        {
            iLogger.write(message, "MESSAGE");
        }

        public void ERROR (string message)
        {
            iLogger.write(message, "ERROR");
        }
        
    }
}
