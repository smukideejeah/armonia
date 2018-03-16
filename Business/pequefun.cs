using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class pequefun
    {
        public static string creaInsert(object o)
        {
            string cmd = "";
            string[] st = o.GetType().ToString().Split('.');
            string nombre = st[st.Length - 1];
            cmd = "insert into " + nombre + " values (";
            for (int x = 1; x <= o.GetType().GetProperties().Length; x++)
            {
                cmd += "@elem" + x;
                if (x < o.GetType().GetProperties().Length) cmd += ",";
            }
            cmd += ");";

            return cmd;
        }

        public static string creaDelete(object o)
        {
            string cmd = "";
            string[] st = o.GetType().ToString().Split('.');
            string nombre = st[st.Length - 1];
            cmd = "delete from " + nombre + " where ";
            int x = 1;
            int lim = o.GetType().GetProperties().Length;
            foreach (System.Reflection.PropertyInfo elem in o.GetType().GetProperties())
            {
                cmd += elem.Name + "=" + "@elem" + x;
                if (x < lim) cmd += " and ";
                x++;
            }
            cmd += ";";

            return cmd;
        }

        public static string creaUpdate(object o)
        {
            string cmd = "";
            string[] st = o.GetType().ToString().Split('.');
            string nombre = st[st.Length - 1];
            cmd = "update " + nombre + " set ";
            int x = 1;
            int lim = o.GetType().GetProperties().Length;
            foreach (System.Reflection.PropertyInfo elem in o.GetType().GetProperties())
            {
                cmd += elem.Name + "=" + "@elem" + x;
                if (x < lim) cmd += ", ";
                x++;
            }
            cmd += " where ";
            foreach (System.Reflection.PropertyInfo elem in o.GetType().GetProperties())
            {
                cmd += elem.Name + "=" + "@elem" + x;
                if (x < 4) cmd += " and ";
                x++;
            }
            cmd += ";";
            return cmd;
        }

        public static MySqlParameter[] creaParams(object o)
        {
            List<MySqlParameter> lp = new List<MySqlParameter>();
            int x = 1;
            foreach (System.Reflection.PropertyInfo elem in o.GetType().GetProperties())
            {
                MySqlParameter mysqlp = new MySqlParameter("@elem" + x, elem.GetValue(o));
                lp.Add(mysqlp);
                x++;
            }

            return lp.ToArray();
        }

        public static MySqlParameter[] creaUpdateParams(object antiguo, object nuevo)
        {
            List<MySqlParameter> lp = new List<MySqlParameter>();
            int x = 1;
            foreach (System.Reflection.PropertyInfo elem in nuevo.GetType().GetProperties())
            {
                MySqlParameter mysqlp = new MySqlParameter("@elem" + x, elem.GetValue(nuevo));
                lp.Add(mysqlp);
                x++;
            }
            foreach (System.Reflection.PropertyInfo elem in antiguo.GetType().GetProperties())
            {
                MySqlParameter mysqlp = new MySqlParameter("@elem" + x, elem.GetValue(antiguo));
                lp.Add(mysqlp);
                x++;
            }
            return lp.ToArray();
        }
    }
}
