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
                empleado encontrado = bEmpleado.login(empl);
                if (encontrado != null)
                {                  
                    BCargo cargo = new BCargo();
                    Dictionary<int, cargo> dictionary = cargo.obtener_cargos(encontrado.id);
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