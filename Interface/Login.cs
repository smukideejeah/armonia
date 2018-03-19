using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Entity;
using Business;

namespace Interface
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        private empleado empl;
        private BEmpleado bEmpleado = new BEmpleado();

        public Login()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            // todo llamar al metodo de bussiness
            string user = txt_user_name.Text;
            string password = txt_password.Text;
            if (user.Length > 0 && password.Length > 0)
            {
                empl = new empleado
                {
                    usuario = user,
                    passwd = password
                };

                if (bEmpleado.login(empl) != null)
                {
                    // con el id del usuario encontrar el cargo para los que tiene acceso
                    Dictionary<int, object> dict = new Dictionary<int, object>();
                    dict.Add(1, new { Text = "Azure", Count = 13, Link = "C#" });
                    dict.Add(2, new { Count = 13, Text = "HTML", Link = "jQuery" });
                    dict.Add(3, new { Counter = 1, Text = "Apples", Link = "Fruit" });
                    foreach (KeyValuePair<int, object> entry in dict)
                    {
                        Console.WriteLine($"{entry.Key} - {string.Join(",", entry.Value)}");
                    }
                    Home inicio = new Home();
                    inicio.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos!!!");
                }
            }
            else
            {
                MessageBox.Show("Fallo al iniciar sesion");
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}