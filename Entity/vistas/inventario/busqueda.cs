using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.vistas.inventario
{
    public class busqueda
    {
        public int id { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public int alerta_minimo { get; set; }
        public string descripcion { get; set; }
        public string imagen { get; set; }
    }
}
