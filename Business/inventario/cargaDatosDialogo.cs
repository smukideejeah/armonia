using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Business.inventario
{
    public static class cargaDatosDialogo
    {
        public static DataTable busqueda(string[] valores, string[] campos)
        {
            try
            {
                string cmd = "select p.id ID, " +
               "p.modelo Modelo, " +
               "p.marca Marca, " +
               "p.alerta_minimo Minimo, " +
               "e.precio Precio " +
               "from " +
               "producto p " +
               "left join existencia e " +
               "on p.id=e.id_prod " +
               "left join sucursal s " +
               "on e.id_sucursal=s.id" +
               " where ";
                int x = 1;
                int lim = campos.Length-1;
                foreach (string campo in campos)
                {
                    if (valores[x - 1] != "")
                    {
                        cmd += "p."+campo + " like '%" + valores[x - 1] + "%'";
                        if (x < lim) cmd += " and ";
                    }
                    x++;
                }
                cmd += " group by p.id;";
                Console.WriteLine(cmd);
                return dataAccess.inventario.select.busqueda(cmd);
            }catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
