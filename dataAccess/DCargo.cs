using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entity;

namespace dataAccess
{
    public class DCargo
    {
        public Dictionary<int, cargo> obtener_cargos(int id_empleado)
        {
            using (MySqlConnection conex = new MySqlConnection("Server=35.231.83.244;Database=armoniaprueba; Uid=armonia; Password=am12345678; Pooling=true;"))
            {
                conex.Open();

                //string sql = "SELECT * FROM cargo AS c INNER JOIN cargo_empleado AS ce ON c.id = ce.id_cargo " +
                //    "INNER JOIN cargo_grupo AS cg ON c.id = cg.id_cargo " +
                //    "INNER JOIN grupo_opcion AS go ON cg.id = go.id_grupo " +
                //    "WHERE ce.id_empleado = @id_empleado";
                string sql = "SELECT " +
                                " c.id AS id_cargo, " +
                                " c.nombre_cargo, " +
                                " c.interfaz, " +
                                " cg.id AS id_grupo, " +
                                " cg.nombre_grupo, " +
                                " cg.nombre_clase, " +
                                " go.id AS id_opcion, " +
                                " go.nombre_opcion, " +
                                " go.nombre_clase, " +
                                " go.glyph " +
                              " FROM cargo AS c " +
                              " INNER JOIN cargo_empleado AS ce ON c.id = ce.id_cargo " +
                              " INNER JOIN cargo_grupo AS cg ON c.id = cg.id_cargo " +
                              " INNER JOIN grupo_opcion AS go ON cg.id = go.id_grupo " +
                                " WHERE ce.id_empleado = @id_empleado";
                Dictionary<int, cargo> cargos = new Dictionary<int, cargo>();

                using (MySqlCommand cmd = new MySqlCommand(sql, conex))
                {
                    cmd.Parameters.AddWithValue("@id_empleado", id_empleado);
                    //cmd.Parameters.AddWithValue("@password", empl.passwd);

                    MySqlDataReader lector = cmd.ExecuteReader();


                    while (lector.Read())
                    {
                        Console.WriteLine(lector["nombre_cargo"]);
                        if (!cargos.ContainsKey(Convert.ToInt32(lector["id_cargo"]))) {
                            cargos.Add(Convert.ToInt32(lector["id_cargo"]), new cargo
                            {
                                id = Convert.ToInt32(lector["id_cargo"]),
                                nombre_cargo = Convert.ToString(lector["nombre_cargo"]),
                                grupos = new List<cargo_grupo>()
                            });
                        }
                       
                        cargo_grupo existe_en_lista = cargos[Convert.ToInt32(lector["id_cargo"])].grupos.Find(x => x.id == Convert.ToInt32(lector["id_grupo"]));
                        if (existe_en_lista == null) { 
                            cargos[Convert.ToInt32(lector["id_cargo"])].grupos.Add(
                                new cargo_grupo {
                                    id = Convert.ToInt32(lector["id_grupo"]),
                                    nombre_grupo = Convert.ToString(lector["nombre_grupo"]),
                                    opciones = new List<grupo_opcion>()
                                }
                            );
                        }

                        // el indce [0] tiene que ser atumatico dependiendo del elemento
                        cargos[Convert.ToInt32(lector["id_cargo"])].grupos[0].opciones.Add( new grupo_opcion {
                            id = Convert.ToInt32(lector["id_opcion"]),
                            id_grupo = Convert.ToInt32(lector["id_grupo"]),
                            nombre_opcion = Convert.ToString(lector["nombre_opcion"])
                        });
                    }
                }
                return cargos;
            }
        }
    }
}
