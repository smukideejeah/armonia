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

namespace armonia.formsInventario
{
    public partial class busqueda : DevExpress.XtraEditors.XtraForm
    {
        string[] vals;
        public busqueda(string [] vals)
        {
            InitializeComponent();
            this.vals = vals;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int id;
            if (dataGridView1.DataSource != null) {
                id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Business.inventario.CargaData.cargarPropiedades(id);
                this.DialogResult = DialogResult.OK;
                Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void busqueda_Load(object sender, EventArgs e)
        {
            string[] campos = { "modelo", "marca", "descripcion" };

            DataTable dt = Business.inventario.cargaDatosDialogo.busqueda(vals, campos);
            if (dt == null)
            {
                MessageBox.Show("Error: Vea la salida del programa", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                Close();
            }
            dataGridView1.DataSource = dt;
        }
    }
}