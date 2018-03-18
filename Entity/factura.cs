using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class factura
    {
        public static int id { get; set; }
        public int idlocal { get; set; }
        public int id_cliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int id_empleado { get; set; }
        public string id_sucursal { get; set; }
        public string fecha { get; set; }
        public double financiamiento { get; set; }
        public double subtotal { get; set; }
        public double total { get; set; }
        public int tipo { get; set; }
        public string estado { get; set; }
    }
}
