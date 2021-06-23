using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoggerTest2.Class
{   
    class LoggerFile : ILogger
    {
        // Singleton
        private static LoggerFile instance;

        private LoggerFile()
        {

        }

        public static LoggerFile Instance { 
            get {
                if (instance == null)
                {
                    instance = new LoggerFile();
                }
                return instance;
             } 
        }
        
        void ILogger.write(string message, string type)
        {
            Console.WriteLine("[" + type + "] " + message);
            try
            {
                using(StreamWriter sw = File.AppendText(".\\test.log"))
                {
                    sw.WriteLine(DateTime.Now + " [" + type + "] " + message);
                }
            }catch(Exception e)
            {
                Console.WriteLine("Error al Escribir en Archivo: " + e );
            }
            finally
            {
                Console.WriteLine("Message saved in file");
            }
        }

    }
}
