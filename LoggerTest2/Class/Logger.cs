using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerTest2.Class
{
    enum TypeDestination { file, console, database, all } 
    class Logger
    {
        private ILogger iLogger;
        public Logger(ILogger iLogger)
        {
            this.iLogger = iLogger;
        }

        public Logger(TypeDestination type)
        {
            switch (type)
            {
                case TypeDestination.file:
                    iLogger = LoggerFile.Instance;
                    break;
                case TypeDestination.console:
                    iLogger = new LoggerConsole();
                    break;
                case TypeDestination.database:
                    iLogger = new LoggerDatabases();
                    break;
                case TypeDestination.all:
                    iLogger = new AllDestination();
                    break;
            }
        }

        public void WARN(string message)
        {
            iLogger.Write(message, "WARN");
        }

        public void INFO (string message)
        {
            iLogger.Write(message, "INFO");
        }

        public void MESSAGE (string message)
        {
            iLogger.Write(message, "MESSAGE");
        }

        public void ERROR (string message)
        {
            iLogger.Write(message, "ERROR");
        }
        
    }
}
