﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerTest2.Class
{
    class LoggerDatabases : ILogger
    {
        void ILogger.write(string message, string type)
        {
            Console.WriteLine("Escribiendo en databases: " + DateTime.Now + " [" + type + "] " + message);
        }
    }
}
