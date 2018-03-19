namespace armonia.formsInventario
{
    partial class listaSucursales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listaSucursales));
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.envia = new DevExpress.XtraEditors.SimpleButton();
            this.cancela = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxControl1.Location = new System.Drawing.Point(12, 12);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(274, 100);
            this.listBoxControl1.TabIndex = 0;
            // 
            // envia
            // 
            this.envia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.envia.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.envia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.envia.Location = new System.Drawing.Point(135, 118);
            this.envia.Name = "envia";
            this.envia.Size = new System.Drawing.Size(153, 65);
            this.envia.TabIndex = 1;
            this.envia.Text = "Enviar la Remision";
            // 
            // cancela
            // 
            this.cancela.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancela.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.cancela.Location = new System.Drawing.Point(12, 118);
            this.cancela.Name = "cancela";
            this.cancela.Size = new System.Drawing.Size(94, 65);
            this.cancela.TabIndex = 1;
            this.cancela.Text = "Cancelar";
            // 
            // listaSucursales
            // 
            this.AcceptButton = this.envia;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancela;
            this.ClientSize = new System.Drawing.Size(300, 195);
            this.Controls.Add(this.cancela);
            this.Controls.Add(this.envia);
            this.Controls.Add(this.listBoxControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "listaSucursales";
            this.Text = "Enviar a...";
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.SimpleButton envia;
        private DevExpress.XtraEditors.SimpleButton cancela;
    }
}