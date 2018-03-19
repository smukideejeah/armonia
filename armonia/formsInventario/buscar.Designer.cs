namespace armonia.formsInventario
{
    partial class buscar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscar));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnbusca = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.cantidad = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.look = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.raddescr = new System.Windows.Forms.RadioButton();
            this.radmodelo = new System.Windows.Forms.RadioButton();
            this.radiomarca = new System.Windows.Forms.RadioButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnagrega = new DevExpress.XtraEditors.SimpleButton();
            this.btnlisto = new DevExpress.XtraEditors.SimpleButton();
            this.btncancelar = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.look.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelControl2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.05634F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.94366F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(730, 327);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(724, 204);
            this.dataGridView1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnbusca);
            this.panelControl1.Controls.Add(this.groupControl3);
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(724, 68);
            this.panelControl1.TabIndex = 1;
            // 
            // btnbusca
            // 
            this.btnbusca.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnbusca.Location = new System.Drawing.Point(579, 5);
            this.btnbusca.Name = "btnbusca";
            this.btnbusca.Size = new System.Drawing.Size(136, 55);
            this.btnbusca.TabIndex = 1;
            this.btnbusca.Text = "Buscar Producto";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.cantidad);
            this.groupControl3.Location = new System.Drawing.Point(463, 6);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(110, 54);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Cantidad";
            this.groupControl3.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(5, 26);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(100, 20);
            this.cantidad.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.look);
            this.groupControl2.Location = new System.Drawing.Point(234, 6);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(223, 54);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Elemento a buscar";
            this.groupControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // look
            // 
            this.look.Location = new System.Drawing.Point(6, 27);
            this.look.Name = "look";
            this.look.Size = new System.Drawing.Size(212, 20);
            this.look.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.raddescr);
            this.groupControl1.Controls.Add(this.radmodelo);
            this.groupControl1.Controls.Add(this.radiomarca);
            this.groupControl1.Location = new System.Drawing.Point(6, 6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(222, 54);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Buscar por...";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // raddescr
            // 
            this.raddescr.AutoSize = true;
            this.raddescr.Location = new System.Drawing.Point(140, 27);
            this.raddescr.Name = "raddescr";
            this.raddescr.Size = new System.Drawing.Size(79, 17);
            this.raddescr.TabIndex = 2;
            this.raddescr.Text = "Descripcion";
            this.raddescr.UseVisualStyleBackColor = true;
            // 
            // radmodelo
            // 
            this.radmodelo.AutoSize = true;
            this.radmodelo.Location = new System.Drawing.Point(74, 27);
            this.radmodelo.Name = "radmodelo";
            this.radmodelo.Size = new System.Drawing.Size(59, 17);
            this.radmodelo.TabIndex = 1;
            this.radmodelo.Text = "Modelo";
            this.radmodelo.UseVisualStyleBackColor = true;
            this.radmodelo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radiomarca
            // 
            this.radiomarca.AutoSize = true;
            this.radiomarca.Checked = true;
            this.radiomarca.Location = new System.Drawing.Point(5, 27);
            this.radiomarca.Name = "radiomarca";
            this.radiomarca.Size = new System.Drawing.Size(54, 17);
            this.radiomarca.TabIndex = 0;
            this.radiomarca.TabStop = true;
            this.radiomarca.Text = "Marca";
            this.radiomarca.UseVisualStyleBackColor = true;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnlisto);
            this.panelControl2.Controls.Add(this.btncancelar);
            this.panelControl2.Controls.Add(this.btnagrega);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(3, 287);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(724, 37);
            this.panelControl2.TabIndex = 2;
            // 
            // btnagrega
            // 
            this.btnagrega.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnagrega.Location = new System.Drawing.Point(405, 5);
            this.btnagrega.Name = "btnagrega";
            this.btnagrega.Size = new System.Drawing.Size(152, 27);
            this.btnagrega.TabIndex = 0;
            this.btnagrega.Text = "&Agregar producto";
            // 
            // btnlisto
            // 
            this.btnlisto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.btnlisto.Location = new System.Drawing.Point(563, 5);
            this.btnlisto.Name = "btnlisto";
            this.btnlisto.Size = new System.Drawing.Size(152, 27);
            this.btnlisto.TabIndex = 0;
            this.btnlisto.Text = "&Listo";
            // 
            // btncancelar
            // 
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image1")));
            this.btncancelar.Location = new System.Drawing.Point(5, 5);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(152, 27);
            this.btncancelar.TabIndex = 0;
            this.btncancelar.Text = "&Cancelar";
            // 
            // buscar
            // 
            this.AcceptButton = this.btnlisto;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btncancelar;
            this.ClientSize = new System.Drawing.Size(730, 327);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "buscar";
            this.Text = "Agregar Producto";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cantidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.look.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.RadioButton radiomarca;
        private DevExpress.XtraEditors.SimpleButton btnbusca;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit look;
        private System.Windows.Forms.RadioButton raddescr;
        private System.Windows.Forms.RadioButton radmodelo;
        private DevExpress.XtraEditors.SimpleButton btnagrega;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit cantidad;
        private DevExpress.XtraEditors.SimpleButton btnlisto;
        private DevExpress.XtraEditors.SimpleButton btncancelar;
    }
}