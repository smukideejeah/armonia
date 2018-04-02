using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Utils;
using Entity;

namespace Interface
{
    public partial class Home : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Dictionary<int, cargo> cargos_empleado;
        private empleado usuario_actual;
        private List<RibbonPage> paginas;
        private List<RibbonPageGroup> grupos;

        public Home(Dictionary<int, cargo> cargos, empleado encontrado)
        {
            this.cargos_empleado = cargos;
            this.usuario_actual = encontrado;
            paginas = new List<RibbonPage>();
            grupos = new List<RibbonPageGroup>();

            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            status_nombre_empleado.Text = "Usuario: " + this.usuario_actual.nombres + " " + this.usuario_actual.apellidos;
            foreach(cargo c in this.cargos_empleado.Values)
            {
                Console.WriteLine(c.nombre_cargo);
            }
            crear_ribbon_control();
        }

        //private void crear_ribbon_control3()
        //{
        //    ImageCollection imageCollection = new ImageCollection();

        //    RibbonControl ribbon = new RibbonControl();
        //    this.Controls.Add(ribbon);

        //    ribbon.Images = imageCollection;

        //    RibbonPage page1 = new RibbonPage("Inventario");
        //    RibbonPage page2 = new RibbonPage("Venta");
        //    RibbonPageGroup group1 = new RibbonPageGroup("File");
        //    RibbonPageGroup group2 = new RibbonPageGroup("File 2");

        //    //BarButtonItem salir = new BarButtonItem();
        //    //salir.Caption = "Salir";
        //    //ApplicationMenu menu = new ApplicationMenu();
        //    //menu.AddItem(salir);
        //    //menu.Ribbon = ribbon;
        //    //ribbon.ApplicationButtonDropDownControl = menu;

        //    BarButtonItem itemOpen = ribbon.Items.CreateButton("Reporte");
        //    itemOpen.ImageIndex = 0;
        //    itemOpen.Id = ribbon.Manager.GetNewItemId();
        //    itemOpen.ItemClick += new ItemClickEventHandler(itemOpen_ItemClick);
        //    itemOpen.Glyph = Interface.Properties.Resources.Inbox_32x32;
        //    itemOpen.RibbonStyle = RibbonItemStyles.All;

        //    //BarButtonItem itemClose = new BarButtonItem(ribbon.Manager, "Close");
        //    BarButtonItem itemClose = ribbon.Items.CreateButton("Close");
        //    itemClose.ImageIndex = 1;
        //    itemClose.Id = ribbon.Manager.GetNewItemId();
        //    itemClose.ItemClick += new ItemClickEventHandler(itemClose_ItemClick);
        //    itemClose.Glyph = Interface.Properties.Resources.Cancel_32x32;
        //    itemClose.RibbonStyle = RibbonItemStyles.All;

        //    BarButtonItem itemVenta = ribbon.Items.CreateButton("Venta");
        //    itemVenta.ImageIndex = 2;
        //    itemVenta.Id = ribbon.Manager.GetNewItemId();
        //    //ItemClickEventArgs datos = new ItemClickEventArgs();
        //    itemVenta.ItemClick += (sender, e) => itemVenta_ItemClick("Hola Mundo");//new ItemClickEventHandler(itemVenta_ItemClick, "zdfdfd");
        //    itemVenta.Glyph = Interface.Properties.Resources.Inbox_32x32;
        //    itemVenta.RibbonStyle = RibbonItemStyles.All;

        //    //itemOpen.Glyph = DevExpress.Utils.imagesR

        //    group1.ItemLinks.AddRange(new BarItem[] { itemOpen, itemClose });
        //    page1.Groups.Add(group1);

        //    group2.ItemLinks.AddRange(new BarItem[] { itemVenta });
        //    page2.Groups.Add(group2);

        //    ribbon.Pages.Add(page1);
        //    ribbon.Pages.Add(page2);
        //}

        private void crear_ribbon_control()
        {
            ImageCollection imageCollection = new ImageCollection();

            RibbonControl ribbon = new RibbonControl();
            this.Controls.Add(ribbon);

            ribbon.Images = imageCollection;
            ribbon.Minimized = true;

            foreach(cargo c in this.cargos_empleado.Values)
            {
                RibbonPage pagina = new RibbonPage(c.nombre_cargo);

                foreach(cargo_grupo g in c.grupos)
                {
                    RibbonPageGroup grupo = new RibbonPageGroup(g.nombre_grupo)
                    {
                        AllowTextClipping = false
                    };                  

                    for(var i = 0; i < g.opciones.Count; i++)
                    {
                        BarButtonItem item = ribbon.Items.CreateButton(g.opciones[i].nombre_opcion);
                        item.ImageIndex = i;
                        item.Id = ribbon.Manager.GetNewItemId();
                        string nombre_clase = g.opciones[i].nombre_clase;
                        item.ItemClick += (sender, EventArgs) => { itemOpen_ItemClick(sender, EventArgs, nombre_clase); };//new ItemClickEventHandler(itemOpen_ItemClick);
                        item.Glyph = (Image)Interface.Properties.Resources.ResourceManager.GetObject(g.opciones[i].glyph.ToString());
                        item.RibbonStyle = RibbonItemStyles.All;

                        grupo.ItemLinks.Add(item);

                    }
                    pagina.Groups.Add(grupo);
                }
                ribbon.Pages.Add(pagina);
            }

        }

        void itemOpen_ItemClick(object sender, ItemClickEventArgs e, string nombre_clase)
        {
            //...

        }
        void itemClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            //..
        }

        void itemVenta_ItemClick(string prueba/*object sender, ItemClickEventArgs e*/)
        {
            //..
            MessageBox.Show(prueba);
        }
    }
}