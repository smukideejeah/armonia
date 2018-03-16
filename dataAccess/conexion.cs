using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace dataAccess
{
    public static class conexion
    {
        public static MySqlConnection mysqlcon;
        public static int iniciar()
        {
            try
            {
                mysqlcon = new MySqlConnection("Server=35.231.83.244;Database=armoniaprueba;Uid=armonia;Pwd=am12345678;");
                mysqlcon.Open();
                return 1;
            }catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
