using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Business.inventario
{
    public static class CargaData
    {
        public static Entity.vistas.inventario.busqueda buscado { get; set; }
        public static Entity.vistas.inventario.todoexistencia existencias { get; set; }

        public static void cargarPropiedades(int id)
        {
            dataAccess.conexion.iniciar();
            string cmd = "select " +
                "p.id, p.marca, p.modelo, p.descripcion, p.imagen, p.alerta_minimo " +
                "from " +
                "producto p" +
                " where " +
                "p.id = " + id;

            DataTable read = dataAccess.inventario.select.recoge(cmd);

            Entity.vistas.inventario.busqueda b = new Entity.vistas.inventario.busqueda();
            if (read.Rows.Count > 0){
                b.marca = read.Rows[0][1].ToString();
                b.modelo = read.Rows[0][2].ToString();
                b.imagen = read.Rows[0][4].ToString();
                b.descripcion = read.Rows[0][3].ToString();
                b.id = int.Parse(read.Rows[0][0].ToString());
                b.alerta_minimo = int.Parse(read.Rows[0][5].ToString());
                buscado = b;
            }else buscado = null;

            Entity.vistas.inventario.todoexistencia e = new Entity.vistas.inventario.todoexistencia();
            read = command("leon", id);
            if (read.Rows.Count > 0)
            {
                e.leon = read.Rows[0][0].ToString();
                e.pleon = read.Rows[0][1].ToString();
            }

            read = command("esteli", id);
            if (read.Rows.Count > 0)
            {
                e.esteli = read.Rows[0][0].ToString();
                e.pesteli = read.Rows[0][1].ToString();
            }

            read = command("matagalpa", id);
            if (read.Rows.Count > 0)
            {
                e.matagalpa = read.Rows[0][0].ToString();
                e.pmatagalpa = read.Rows[0][1].ToString();
            }

            read = command("jinotega", id);
            if (read.Rows.Count > 0)
            {
                e.jinotega = read.Rows[0][0].ToString();
                e.pjinotega = read.Rows[0][1].ToString();
            }
            read = command("chinandega", id);
            if (read.Rows.Count > 0)
            {
                e.chinandega = read.Rows[0][0].ToString();
                e.pchinandega = read.Rows[0][1].ToString();
            }
            existencias = e;
            dataAccess.conexion.mysqlcon.Close();
        }
        static DataTable command(string suc, int id)
        {
            return dataAccess.inventario.select.recoge("select existencia, precio from existencia where id_prod = " + id + " and id_sucursal = '"+suc+"'");
        }
    }
}
