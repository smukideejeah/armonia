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
            Business.inventario.SystemAndUserData.sucursal = "leon";

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

        /********************Ver Campos***********************/

        private void simpleButton1_Click(object sender, EventArgs e)
        {  
            string[] vals = new string[3];
            vals[0] = radiomodelo.Text;
            vals[1] = radiomarca.Text;
            vals[2] = radiodescr.Text;
            busqueda b = new busqueda(vals);
            if (ValidaBusqueda() == true)
            {
                if (b.ShowDialog() == DialogResult.OK)
                {
                    Entity.vistas.inventario.busqueda bu = Business.inventario.CargaData.buscado;
                    Entity.vistas.inventario.todoexistencia te = Business.inventario.CargaData.existencias;
                    code.Text = bu.id.ToString();
                    marca.Text = bu.marca;
                    model.Text = bu.modelo;
                    descripcion.Text = bu.descripcion;
                    imagen.Image = Business.inventario.metodos.Base64ToImage(bu.imagen);
                    if (bu.alerta_minimo == 1) minimo.Checked = true;
                    else minimo.Checked = false;

                    uleon.Text = te.leon;
                    umatagalpa.Text = te.matagalpa;
                    ujinotega.Text = te.jinotega;
                    uesteli.Text = te.esteli;
                    uchinandega.Text = te.chinandega;

                    pleon.Text = te.pleon;
                    pmatagalpa.Text = te.pmatagalpa;
                    pjinotega.Text = te.pjinotega;
                    pesteli.Text = te.pesteli;
                    pchinandega.Text = te.pchinandega;

                }
                radiodescr.Text = radiomarca.Text = radiomodelo.Text = "";
            }
            else MessageBox.Show("Debes ingresar datos en al menos un campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /////////////////////////////////////////////////////////////////////////

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


        private void simpleButton8_Click(object sender, EventArgs e)
        {
            listaSucursales ls = new listaSucursales();
            ls.ShowDialog();
            if(ls.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Pulso OK","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        
        /*************Validaciones***********************/
        void limpia()
        {
            code.Text = marca.Text = model.Text = descripcion.Text = 
                pleon.Text = pmatagalpa.Text = pjinotega.Text = pesteli.Text = pchinandega.Text = 
                uleon.Text = umatagalpa.Text = uchinandega.Text = uesteli.Text = ujinotega.Text = "";
            minimo.Checked = false;
            imagen.Image = null;
        }

        private bool ValidaBusqueda()
        {

            if (radiodescr.Text != "") return true;
            if (radiomarca.Text != "") return true;
            if (radiomodelo.Text != "") return true;
            return false;
        }

        void abajo(bool enable)
        {
            code.Enabled = marca.Enabled =
                model.Enabled = descripcion.Enabled = uleon.Enabled =
                umatagalpa.Enabled = ujinotega.Enabled = uesteli.Enabled =
                uchinandega.Enabled = minimo.Enabled = imagen.Enabled =
                pleon.Enabled = pmatagalpa.Enabled = pjinotega.Enabled = pesteli.Enabled = pchinandega.Enabled = 
                enable;
        }

        void arriba(bool enable)
        {
            radiomodelo.Enabled = radiomarca.Enabled = radiodescr.Enabled =
                radiomodelo.Enabled = busca.Enabled =
                enable;
        }

        /***********************CRUD************************/

        void actualiza(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("Estas seguro que deseas actualizar el producto?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ds == DialogResult.OK)
            {
                Entity.vistas.inventario.busqueda b = Business.inventario.CargaData.buscado;
                Entity.vistas.inventario.busqueda bu = new Entity.vistas.inventario.busqueda();
                bu.marca = marca.Text;
                bu.modelo = model.Text;
                bu.descripcion = descripcion.Text;
                
            }
                
        }
        void inserta(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("Estas seguro que deseas eliminar el archivo?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ds == DialogResult.OK)
                MessageBox.Show("Eliminado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void elimina(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("Estas seguro que deseas eliminar el archivo?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ds == DialogResult.OK)
                MessageBox.Show("Eliminado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
