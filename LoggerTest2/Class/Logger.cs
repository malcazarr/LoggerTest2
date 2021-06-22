using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerTest2.Class
{
    class Logger
    {
        private ILogger iLogger;

        public Logger(ILogger iLogger)
        {
            this.iLogger = iLogger;
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
