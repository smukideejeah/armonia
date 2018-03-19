using armonia.formsInventario;
using System;
using System.Windows.Forms;
using armonia.Properties;

namespace armonia.formsInventario
{
    public partial class inventario : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public inventario()
        {
            InitializeComponent();
        }
        private void cerrado(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabmadre.SelectedTabPage = tabbuscar;
            abajo(false);
            guarda.Visible = false;
        }

        private void botonactualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabmadre.SelectedTabPage = tabbuscar;
            arriba(true);
            abajo(true);
            guarda.Visible = true;
            guarda.Text = "Actualizar Producto";
            guarda.ImageOptions.Image = Resources.save_32x32;
            guarda.Click += new EventHandler(actualiza);
        }

        private void botoninsertar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabmadre.SelectedTabPage = tabbuscar;
            arriba(false);
            abajo(true);
            guarda.Visible = true;
            guarda.Text = "Insertar Producto";
            guarda.ImageOptions.Image = Resources.insertsheet_32x32;
            guarda.Click += new EventHandler(inserta);
        }

        private void botoneliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabmadre.SelectedTabPage = tabbuscar;
            arriba(true);
            abajo(false);
            guarda.Visible = true;
            guarda.Text = "Eliminar Producto";
            guarda.ImageOptions.Image = Resources.deletesheetrows_32x32;
            guarda.Click += new EventHandler(elimina);
        }

        private void botontodo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //dataGridView1.DataSource = database.todosproductos();
            tabmadre.SelectedTabPage = tabtodo;
        }

        private void botonreporte_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabmadre.SelectedTabPage = tabreporte;
        }

        private void botonsalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            busqueda b = new busqueda();
            b.ShowDialog();
        }

        private void botonpocas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabmadre.SelectedTabPage = tabtodo;
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true) dateEdit2.Enabled = false;
            else dateEdit2.Enabled = true;
        }

        private void enviar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tabmadre.SelectedTabPage == remision) new buscar().ShowDialog();
            else tabmadre.SelectedTabPage = remision;
        }

        private void solicitar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tabmadre.SelectedTabPage = remision;
        }
        void abajo(bool enable)
        {
            code.Enabled = marca.Enabled =
                model.Enabled = descripcion.Enabled = uleon.Enabled =
                umatagalpa.Enabled = ujinotega.Enabled = uesteli.Enabled =
                uchinandega.Enabled =
                enable;
        }
        void arriba(bool enable)
        {
            radiomodelo.Enabled = radiomarca.Enabled = radiodescr.Enabled =
                nombre.Enabled = busca.Enabled =
                enable;
        }
        void actualiza(object sender, EventArgs e)
        {

        }
        void inserta(object sender, EventArgs e)
        {

        }
        void elimina(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("Estas seguro que deseas eliminar el archivo?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ds == DialogResult.OK)
                MessageBox.Show("Eliminado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            listaSucursales ls = new listaSucursales();
            ls.ShowDialog();
            if(ls.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Pulso OK","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
