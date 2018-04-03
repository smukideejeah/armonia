namespace Interface.facturacion
{
    partial class AGREGAR_PRODUCTO
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
            this.dataGridView1_agregar = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.cbagregar_codigo = new System.Windows.Forms.ComboBox();
            this.cbagregar_nombre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbdescuento = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_agregar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1_agregar
            // 
            this.dataGridView1_agregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_agregar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1_agregar.Location = new System.Drawing.Point(41, 153);
            this.dataGridView1_agregar.Name = "dataGridView1_agregar";
            this.dataGridView1_agregar.Size = new System.Drawing.Size(455, 142);
            this.dataGridView1_agregar.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CODIGO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "NOMBRE:";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CODIGO";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "MARCA";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DESCRIPCION";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PRECIO";
            this.Column4.Name = "Column4";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(232, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 50);
            this.button1.TabIndex = 11;
            this.button1.Text = "AÑADIR PRODUCTO";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cbagregar_codigo
            // 
            this.cbagregar_codigo.FormattingEnabled = true;
            this.cbagregar_codigo.Location = new System.Drawing.Point(93, 71);
            this.cbagregar_codigo.Name = "cbagregar_codigo";
            this.cbagregar_codigo.Size = new System.Drawing.Size(121, 21);
            this.cbagregar_codigo.TabIndex = 12;
            // 
            // cbagregar_nombre
            // 
            this.cbagregar_nombre.FormattingEnabled = true;
            this.cbagregar_nombre.Location = new System.Drawing.Point(448, 71);
            this.cbagregar_nombre.Name = "cbagregar_nombre";
            this.cbagregar_nombre.Size = new System.Drawing.Size(121, 21);
            this.cbagregar_nombre.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "DESCUENTO:";
            // 
            // cbdescuento
            // 
            this.cbdescuento.FormattingEnabled = true;
            this.cbdescuento.Location = new System.Drawing.Point(605, 166);
            this.cbdescuento.Name = "cbdescuento";
            this.cbdescuento.Size = new System.Drawing.Size(97, 21);
            this.cbdescuento.TabIndex = 15;
            // 
            // AGREGAR_PRODUCTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbdescuento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbagregar_nombre);
            this.Controls.Add(this.cbagregar_codigo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1_agregar);
            this.Name = "AGREGAR_PRODUCTO";
            this.Text = "AGREGAR_PRODUCTO";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_agregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1_agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbagregar_codigo;
        private System.Windows.Forms.ComboBox cbagregar_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbdescuento;
    }
}