using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entity;
using Business;

namespace dataAccess
{
    public static class InsertUpdDel
    {

        public static bool insertar(object dato)
        {
            bool retur = false;
            try
            {
                string cmd = pequefun.creaInsert(dato);
                using (MySqlCommand mysqlc = new MySqlCommand(cmd, conexion.mysqlcon))
                {
                    mysqlc.Parameters.AddRange(pequefun.creaParams(dato));
                    mysqlc.ExecuteNonQuery();
                }
                retur = true;
            }
            catch (MySqlException ex)
            {
                retur = false;
            }
            return retur;
        }
        public static bool eliminar(object dato)
        {
            bool retur = false;
            try
            {
                string cmd = pequefun.creaDelete(dato);
                using (MySqlCommand mysqlc = new MySqlCommand(cmd, conexion.mysqlcon))
                {
                    mysqlc.Parameters.AddRange(pequefun.creaParams(dato));
                    mysqlc.ExecuteNonQuery();
                }
                retur = true;
            }
            catch (MySqlException ex)
            {
                retur = false;
            }
            return retur;
        }

        public static bool actualizar(object antiguo, object nuevo)
        {
            bool retur = false;
            try
            {
                string cmd = pequefun.creaUpdate(antiguo);
                using (MySqlCommand mysqlc = new MySqlCommand(cmd, conexion.mysqlcon))
                {
                    mysqlc.Parameters.AddRange(pequefun.creaUpdateParams(antiguo,nuevo));
                    mysqlc.ExecuteNonQuery();
                }
                retur = true;
            }
            catch (MySqlException ex)
            {
                retur = false;
            }
            return retur;
        }
    }
}
