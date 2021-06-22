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
            Console.WriteLine("Escribiendo en Console: " + "[" + type + "] " + message);
            Console.WriteLine("Escribiendo en Database: " + "[" + type + "] " + message);
            Console.WriteLine("Escribiendo en File: " + "[" + type + "] " + message);
        }
    }
}
