using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerTest2.Class
{
    class LoggerConsole: ILogger
    {
        void ILogger.write(string message, string type)
        {
           Console.WriteLine(DateTime.Now + " [" + type + "] " + message);
        }
    }
}
