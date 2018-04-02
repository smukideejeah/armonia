using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace dataAccess
{
    public static class InsertUpdDel
    {

        public static bool insertar(object dato)
        {
            bool retur = false;
            try
            {
                string cmd = generar.creaInsert(dato);
                using (MySqlCommand mysqlc = new MySqlCommand(cmd, conexion.mysqlcon))
                {
                    mysqlc.Parameters.AddRange(generar.creaParams(dato));
                    mysqlc.ExecuteNonQuery();
                }
                retur = true;
            }
            catch (MySqlException)
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
                conexion.iniciar();
                string cmd = generar.creaDelete(dato);
                using (MySqlCommand mysqlc = new MySqlCommand(cmd, conexion.mysqlcon))
                {
                    mysqlc.Parameters.AddRange(generar.creaParams(dato));
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
                string cmd = generar.creaUpdate(antiguo);
                using (MySqlCommand mysqlc = new MySqlCommand(cmd, conexion.mysqlcon))
                {
                    mysqlc.Parameters.AddRange(generar.creaUpdateParams(antiguo,nuevo));
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
