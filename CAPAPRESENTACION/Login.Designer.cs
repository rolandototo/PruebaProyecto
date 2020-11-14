namespace CAPAPRESENTACION
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
            this.limpiarlabel = new System.Windows.Forms.LinkLabel();
            this.BTNLOGIN = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TXTUSER = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TXTPASS = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelFill.SuspendLayout();
            this.PanelDerecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelFill
            // 
            this.PanelFill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(86)))), ((int)(((byte)(192)))));
            this.PanelFill.Controls.Add(this.label3);
            this.PanelFill.Controls.Add(this.TXTPASS);
            this.PanelFill.Controls.Add(this.TXTUSER);
            this.PanelFill.Controls.Add(this.label2);
            this.PanelFill.Controls.Add(this.label1);
            this.PanelFill.Controls.Add(this.BTNLOGIN);
            this.PanelFill.Controls.Add(this.limpiarlabel);
            this.PanelFill.Location = new System.Drawing.Point(550, 40);
            this.PanelFill.MaximumSize = new System.Drawing.Size(537, 464);
            this.PanelFill.MinimumSize = new System.Drawing.Size(537, 464);
            this.PanelFill.Size = new System.Drawing.Size(537, 464);
            // 
            // PanelArriba
            // 
            this.PanelArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(86)))), ((int)(((byte)(192)))));
            this.PanelArriba.Location = new System.Drawing.Point(550, 0);
            this.PanelArriba.Size = new System.Drawing.Size(537, 40);
            // 
            // PanelDerecha
            // 
            this.PanelDerecha.Controls.Add(this.pictureBox1);
            this.PanelDerecha.Size = new System.Drawing.Size(550, 504);
            // 
            // limpiarlabel
            // 
            this.limpiarlabel.AutoSize = true;
            this.limpiarlabel.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarlabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(204)))), ((int)(((byte)(245)))));
            this.limpiarlabel.Location = new System.Drawing.Point(219, 309);
            this.limpiarlabel.Name = "limpiarlabel";
            this.limpiarlabel.Size = new System.Drawing.Size(118, 18);
            this.limpiarlabel.TabIndex = 11;
            this.limpiarlabel.TabStop = true;
            this.limpiarlabel.Text = "Limpiar Campos";
            this.limpiarlabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.limpiarlabel_LinkClicked);
            // 
            // BTNLOGIN
            // 
            this.BTNLOGIN.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(96)))), ((int)(((byte)(126)))));
            this.BTNLOGIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(96)))), ((int)(((byte)(126)))));
            this.BTNLOGIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNLOGIN.BorderRadius = 7;
            this.BTNLOGIN.ButtonText = "Iniciar Sesion";
            this.BTNLOGIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNLOGIN.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(96)))), ((int)(((byte)(126)))));
            this.BTNLOGIN.Iconcolor = System.Drawing.Color.Transparent;
            this.BTNLOGIN.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTNLOGIN.Iconimage")));
            this.BTNLOGIN.Iconimage_right = null;
            this.BTNLOGIN.Iconimage_right_Selected = null;
            this.BTNLOGIN.Iconimage_Selected = null;
            this.BTNLOGIN.IconMarginLeft = 0;
            this.BTNLOGIN.IconMarginRight = 0;
            this.BTNLOGIN.IconRightVisible = true;
            this.BTNLOGIN.IconRightZoom = 0D;
            this.BTNLOGIN.IconVisible = true;
            this.BTNLOGIN.IconZoom = 90D;
            this.BTNLOGIN.IsTab = false;
            this.BTNLOGIN.Location = new System.Drawing.Point(149, 351);
            this.BTNLOGIN.Name = "BTNLOGIN";
            this.BTNLOGIN.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(96)))), ((int)(((byte)(126)))));
            this.BTNLOGIN.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(96)))), ((int)(((byte)(126)))));
            this.BTNLOGIN.OnHoverTextColor = System.Drawing.Color.White;
            this.BTNLOGIN.selected = false;
            this.BTNLOGIN.Size = new System.Drawing.Size(258, 48);
            this.BTNLOGIN.TabIndex = 83;
            this.BTNLOGIN.Text = "Iniciar Sesion";
            this.BTNLOGIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTNLOGIN.Textcolor = System.Drawing.Color.White;
            this.BTNLOGIN.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.BTNLOGIN.Click += new System.EventHandler(this.BTNLOGIN_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(204)))), ((int)(((byte)(245)))));
            this.label1.Location = new System.Drawing.Point(234, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 84;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(204)))), ((int)(((byte)(245)))));
            this.label2.Location = new System.Drawing.Point(217, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 85;
            this.label2.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 504);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TXTUSER
            // 
            this.TXTUSER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.TXTUSER.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.TXTUSER.BorderColorIdle = System.Drawing.Color.Silver;
            this.TXTUSER.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.TXTUSER.BorderThickness = 3;
            this.TXTUSER.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTUSER.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTUSER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(204)))), ((int)(((byte)(245)))));
            this.TXTUSER.isPassword = false;
            this.TXTUSER.Location = new System.Drawing.Point(115, 150);
            this.TXTUSER.Margin = new System.Windows.Forms.Padding(5);
            this.TXTUSER.Name = "TXTUSER";
            this.TXTUSER.Size = new System.Drawing.Size(326, 40);
            this.TXTUSER.TabIndex = 86;
            this.TXTUSER.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TXTPASS
            // 
            this.TXTPASS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.TXTPASS.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.TXTPASS.BorderColorIdle = System.Drawing.Color.Silver;
            this.TXTPASS.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(70)))), ((int)(((byte)(167)))));
            this.TXTPASS.BorderThickness = 3;
            this.TXTPASS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTPASS.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTPASS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(204)))), ((int)(((byte)(245)))));
            this.TXTPASS.isPassword = true;
            this.TXTPASS.Location = new System.Drawing.Point(115, 246);
            this.TXTPASS.Margin = new System.Windows.Forms.Padding(5);
            this.TXTPASS.Name = "TXTPASS";
            this.TXTPASS.Size = new System.Drawing.Size(326, 42);
            this.TXTPASS.TabIndex = 87;
            this.TXTPASS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 18.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(204)))), ((int)(((byte)(245)))));
            this.label3.Location = new System.Drawing.Point(70, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(419, 73);
            this.label3.TabIndex = 88;
            this.label3.Text = "UMA\r\nUNIVERSITY MANAGEMENT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1087, 504);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1103, 543);
            this.MinimumSize = new System.Drawing.Size(1103, 543);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.PanelFill.ResumeLayout(false);
            this.PanelFill.PerformLayout();
            this.PanelDerecha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel limpiarlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton BTNLOGIN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox TXTPASS;
        private Bunifu.Framework.UI.BunifuMetroTextbox TXTUSER;
        private System.Windows.Forms.Label label3;
    }
}