namespace Interface
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bt_login = new DevExpress.XtraEditors.SimpleButton();
            this.txt_user_name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_password = new DevExpress.XtraEditors.TextEdit();
            this.bt_cancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(23, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Usuario:";
            // 
            // bt_login
            // 
            this.bt_login.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.bt_login.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_login.ImageOptions.Image")));
            this.bt_login.Location = new System.Drawing.Point(23, 320);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(209, 40);
            this.bt_login.TabIndex = 1;
            this.bt_login.Text = "Iniciar Sesión";
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // txt_user_name
            // 
            this.txt_user_name.Location = new System.Drawing.Point(127, 39);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_user_name.Properties.Appearance.Font = new System.Drawing.Font("Roboto Cn", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_name.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txt_user_name.Properties.Appearance.Options.UseBackColor = true;
            this.txt_user_name.Properties.Appearance.Options.UseFont = true;
            this.txt_user_name.Properties.Appearance.Options.UseForeColor = true;
            this.txt_user_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txt_user_name.Size = new System.Drawing.Size(321, 22);
            this.txt_user_name.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(23, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Contraseña:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(127, 87);
            this.txt_password.Name = "txt_password";
            this.txt_password.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_password.Properties.Appearance.Font = new System.Drawing.Font("Roboto Cn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txt_password.Properties.Appearance.Options.UseBackColor = true;
            this.txt_password.Properties.Appearance.Options.UseFont = true;
            this.txt_password.Properties.Appearance.Options.UseForeColor = true;
            this.txt_password.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txt_password.Size = new System.Drawing.Size(321, 24);
            this.txt_password.TabIndex = 4;
            // 
            // bt_cancel
            // 
            this.bt_cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.bt_cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_cancel.ImageOptions.Image")));
            this.bt_cancel.Location = new System.Drawing.Point(248, 320);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(200, 40);
            this.bt_cancel.TabIndex = 5;
            this.bt_cancel.Text = "Cancelar";
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // Login
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 398);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_user_name);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.LookAndFeel.SkinMaskColor = System.Drawing.Color.DimGray;
            this.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LookAndFeel.SkinName = "Dark Side";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.txt_user_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton bt_login;
        private DevExpress.XtraEditors.TextEdit txt_user_name;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_password;
        private DevExpress.XtraEditors.SimpleButton bt_cancel;
    }
}