using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace LoggerTest2.Class
{
    class DBConnection
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-A00P416;database=Test;Trusted_Connection=True;");
        public bool connect()
        {

            try
            {
                con.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar con la base de datos: " + ex);
                return false;
            }
        }

        public bool disconnect()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al desconectar con la base de datos: " + ex);
                return false;
            }
        }
        public bool SaveLog(string message, string type)
        {
            try
            {
                string query = "INSERT INTO Log (type, message) values('" + type + "','" + message + "')";
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                this.disconnect();
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine("Error al insertar registros a la base de datos: " + e );
                return false;
            }

        }

    }
}
