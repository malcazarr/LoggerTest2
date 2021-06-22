using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggerTest2.Class;
namespace LoggerTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start to console...");


            //var loggfileInstance = LoggerFile.Instance;
            //Logger logger = new Logger(loggfileInstance);
            Logger logger = new Logger(new AllDestination());
            for (var i = 1; i <= 10; i++)
            {
                logger.INFO("Message: " + i);
            }
            Console.WriteLine("End of messages");
            Console.ReadLine();
        }
    }
}
