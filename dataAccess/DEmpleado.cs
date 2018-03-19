using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entity;

namespace dataAccess
{
    public class DEmpleado
    {
        public empleado login(empleado empl)
        {
            using (MySqlConnection conex = new MySqlConnection("Server=35.231.83.244;Database=armoniaprueba; Uid=armonia; Password=am12345678; Pooling=true;"))
            {
                conex.Open();

                string sql = "SELECT * FROM empleado WHERE usuario = @user AND passwd = @password";
                empleado empleado_encontrado = null;

                using (MySqlCommand cmd = new MySqlCommand(sql, conex))
                {
                    cmd.Parameters.AddWithValue("@user", empl.usuario);
                    cmd.Parameters.AddWithValue("@password", empl.passwd);

                    MySqlDataReader lector = cmd.ExecuteReader();


                    if (lector.Read())
                    {
                        empleado_encontrado = new empleado
                        {
                            id = Convert.ToInt32(lector["id"]),
                            usuario = Convert.ToString(lector["usuario"]),
                            nombres = Convert.ToString(lector["nombres"]),
                            apellidos = Convert.ToString(lector["apellidos"]),
                            cedula = Convert.ToString(lector["cedula"]),
                            id_sucursal = Convert.ToString(lector["id_sucursal"]),
                            passwd = Convert.ToString(lector["passwd"])
                        };
                    }
                }
                return empleado_encontrado;
            }
        }
    }
}
