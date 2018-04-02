using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace dataAccess.inventario
{
    public static class select
    {
        public static DataTable busqueda(string cmd)
        {
            conexion.iniciar();
            using(MySqlCommand mysqlc = new MySqlCommand(cmd, conexion.mysqlcon))
            {
                MySqlDataAdapter mysqld = new MySqlDataAdapter(mysqlc);
                DataTable dt = new DataTable();
                mysqld.Fill(dt);
                conexion.mysqlcon.Close();
                return dt;
            }
        }

        public static DataTable recoge(string cmd)
        {
            using(MySqlCommand mc = conexion.mysqlcon.CreateCommand()) {
                mc.CommandType = CommandType.Text;
                mc.CommandText = cmd;
                MySqlDataAdapter myd = new MySqlDataAdapter(mc);
                DataTable dt = new DataTable();
                myd.Fill(dt);
                return dt;
            }
        }
    }
}
