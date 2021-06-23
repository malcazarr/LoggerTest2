using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace LoggerTest2.Class
{
    class LoggerDatabases : ILogger
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-A00P416;database=Test;Trusted_Connection=True;");
        void ILogger.Write(string message, string type)
        {
            Console.WriteLine("Escribiendo en databases: " + DateTime.Now + " [" + type + "] " + message);
            SendDatabase(message, type);
        }

        private void SendDatabase (string message, string type)
        {
            var connection = new DBConnection();
            if (connection.connect())
            {
                connection.SaveLog(message, type);
            }
        }
    }
}
