using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface;






namespace Interface.facturacion
{
   

    public partial class VENTA : Form
    {
        

        public VENTA()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            AGREGAR_PRODUCTO frm = new AGREGAR_PRODUCTO();

            frm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void dataGridView_venta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
