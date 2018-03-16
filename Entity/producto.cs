using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class producto
    {
        public int id { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public string imagen { get; set; }
        public string descripcion { get; set; }
        public int alerta_minimo { get; set; }
    }
}
