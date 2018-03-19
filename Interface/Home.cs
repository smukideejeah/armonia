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

namespace Interface
{
    public partial class Home : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // N paginas
            // N grupos x paginas
            // N items x grupos
            int n_paginas = 4;
            int n_grupos_paginas = 2;
            int n_items_grupo = 3;
            crear_ribbon_control();
        }

        private void crear_ribbon_control()
        {
            ImageCollection imageCollection = new ImageCollection();

            RibbonControl ribbon = new RibbonControl();
            this.Controls.Add(ribbon);

            ribbon.Images = imageCollection;

            RibbonPage page1 = new RibbonPage("Inventario");
            RibbonPage page2 = new RibbonPage("Venta");
            RibbonPageGroup group1 = new RibbonPageGroup("File");
            RibbonPageGroup group2 = new RibbonPageGroup("File 2");

            //BarButtonItem salir = new BarButtonItem();
            //salir.Caption = "Salir";
            //ApplicationMenu menu = new ApplicationMenu();
            //menu.AddItem(salir);
            //menu.Ribbon = ribbon;
            //ribbon.ApplicationButtonDropDownControl = menu;

            BarButtonItem itemOpen = ribbon.Items.CreateButton("Reporte");
            itemOpen.ImageIndex = 0;
            itemOpen.Id = ribbon.Manager.GetNewItemId();
            itemOpen.ItemClick += new ItemClickEventHandler(itemOpen_ItemClick);
            itemOpen.Glyph = Interface.Properties.Resources.Inbox_32x32;
            itemOpen.RibbonStyle = RibbonItemStyles.All;

            //BarButtonItem itemClose = new BarButtonItem(ribbon.Manager, "Close");
            BarButtonItem itemClose = ribbon.Items.CreateButton("Close");
            itemClose.ImageIndex = 1;
            itemClose.Id = ribbon.Manager.GetNewItemId();
            itemClose.ItemClick += new ItemClickEventHandler(itemClose_ItemClick);
            itemClose.Glyph = Interface.Properties.Resources.Cancel_32x32;
            itemClose.RibbonStyle = RibbonItemStyles.All;

            BarButtonItem itemVenta = ribbon.Items.CreateButton("Venta");
            itemVenta.ImageIndex = 2;
            itemVenta.Id = ribbon.Manager.GetNewItemId();
            itemVenta.ItemClick += new ItemClickEventHandler(itemVenta_ItemClick);
            itemVenta.Glyph = Interface.Properties.Resources.Inbox_32x32;
            itemVenta.RibbonStyle = RibbonItemStyles.All;

            //itemOpen.Glyph = DevExpress.Utils.imagesR

            group1.ItemLinks.AddRange(new BarItem[] { itemOpen, itemClose });
            page1.Groups.Add(group1);

            group2.ItemLinks.AddRange(new BarItem[] { itemVenta });
            page2.Groups.Add(group2);

            ribbon.Pages.Add(page1);
            ribbon.Pages.Add(page2);
        }

        void itemOpen_ItemClick(object sender, ItemClickEventArgs e)
        {
            //...
        }
        void itemClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            //..
        }

        void itemVenta_ItemClick(object sender, ItemClickEventArgs e)
        {
            //..
        }
    }
}