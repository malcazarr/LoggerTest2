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

            //logging for file
            //Logger logger = new Logger( LoggerFile.Instance);

            //loggin for Console
            //Logger logger = new Logger(new LoggerConsole());

            //loggin for Databases
            //Logger logger = new Logger(new LoggerDatabases());

            //Loggin for All Destination
            //Logger logger = new Logger(new AllDestination());

            //Loggin declarating Destination  ["file","console","database","all"]
            Logger logger = new Logger(typeDestination.file);

            for (var i = 1; i <= 10; i++)
            {
                logger.INFO("Message INFO: " + i);
                logger.WARN("Message WARN: "  + i );
                logger.MESSAGE("Single MESSAGE: " + i );
                logger.ERROR("Message ERROR: " + i);
            }
            Console.WriteLine("End of messages");
            Console.ReadLine();
        }
    }
}
