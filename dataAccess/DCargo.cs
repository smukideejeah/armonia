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
                                " go.nombre_clase AS nombre_clase_opcion, " +
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
                        // Agregar solo una vez cada cargo
                        if (!cargos.ContainsKey(Convert.ToInt32(lector["id_cargo"]))) {
                            cargos.Add(Convert.ToInt32(lector["id_cargo"]), new cargo
                            {
                                id = Convert.ToInt32(lector["id_cargo"]),
                                nombre_cargo = Convert.ToString(lector["nombre_cargo"]),
                                grupos = new List<cargo_grupo>()
                            });
                        }

                        // Verificar si el cargo creado tiene grupos, si no es asi agregarlo                      
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
                        
                        // Obtener el indice del grupo actual
                        int index = cargos[Convert.ToInt32(lector["id_cargo"])].grupos.FindIndex(x => x.id == Convert.ToInt32(lector["id_grupo"]));

                        // Agregar las opciones a dicho grupo
                        cargos[Convert.ToInt32(lector["id_cargo"])].grupos[index].opciones.Add( new grupo_opcion {
                            id = Convert.ToInt32(lector["id_opcion"]),
                            id_grupo = Convert.ToInt32(lector["id_grupo"]),
                            nombre_opcion = Convert.ToString(lector["nombre_opcion"]),
                            nombre_clase = Convert.ToString(lector["nombre_clase_opcion"]),
                            glyph = Convert.ToString(lector["glyph"])
                        });
                    }
                }
                return cargos;
            }
        }
    }
}
