using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using dataAccess;

namespace Business
{
    public class BCargo
    {
        private DCargo cargo = new DCargo();

        public Dictionary<int, cargo> obtener_cargos(int id_empleado)
        {
            return cargo.obtener_cargos(id_empleado);
        }
    }
}
