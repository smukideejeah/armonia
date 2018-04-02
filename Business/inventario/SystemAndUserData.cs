using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.inventario
{
    public static class SystemAndUserData
    {
        public static string sucursal { get; set; }

        public static void iniciarConexion()
        {
            dataAccess.conexion.iniciar();
        }
    }
}
