using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dataAccess;
using Entity;

namespace Business
{
    public class BEmpleado
    {
        private DEmpleado dEmpleado = new DEmpleado();

        public empleado login(empleado empl)
        {
            return dEmpleado.login(empl);
        }
    }
}
