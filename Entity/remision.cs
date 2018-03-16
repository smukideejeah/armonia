using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class remision
    {
        public int id { get; set; }
        public string suc_origen { get; set; }
        public int envia { get; set; }
        public string suc_destino { get; set; }
        public int recibe { get; set; }
        public string estado { get; set; }
    }
}
