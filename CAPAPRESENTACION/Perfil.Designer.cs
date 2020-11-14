namespace CAPAPRESENTACION
{
    partial class Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNGUARDAR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BTNEDITAR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtsede = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtcorreosec = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtcorreo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtdireccion = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txttelefono = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtapellidos = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtnombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.USERIMAGE = new System.Windows.Forms.PictureBox();
            this.lbUSER = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.LBCARRERA = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.USERIMAGE)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelArriba
            // 
            this.PanelArriba.Size = new System.Drawing.Size(1066, 62);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Correo Secundario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Sede";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BTNGUARDAR);
            this.groupBox1.Controls.Add(this.BTNEDITAR);
            this.groupBox1.Controls.Add(this.txtsede);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtcorreosec);
            this.groupBox1.Controls.Add(this.txtcorreo);
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.txttelefono);
            this.groupBox1.Controls.Add(this.txtapellidos);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 12.25F);
            this.groupBox1.Location = new System.Drawing.Point(695, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 660);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tus Datos";
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNGUARDAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNGUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNGUARDAR.BorderRadius = 7;
            this.BTNGUARDAR.ButtonText = "GUARDAR";
            this.BTNGUARDAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNGUARDAR.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNGUARDAR.Iconcolor = System.Drawing.Color.Transparent;
            this.BTNGUARDAR.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTNGUARDAR.Iconimage")));
            this.BTNGUARDAR.Iconimage_right = null;
            this.BTNGUARDAR.Iconimage_right_Selected = null;
            this.BTNGUARDAR.Iconimage_Selected = null;
            this.BTNGUARDAR.IconMarginLeft = 0;
            this.BTNGUARDAR.IconMarginRight = 0;
            this.BTNGUARDAR.IconRightVisible = true;
            this.BTNGUARDAR.IconRightZoom = 0D;
            this.BTNGUARDAR.IconVisible = true;
            this.BTNGUARDAR.IconZoom = 90D;
            this.BTNGUARDAR.IsTab = false;
            this.BTNGUARDAR.Location = new System.Drawing.Point(94, 587);
            this.BTNGUARDAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNGUARDAR.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNGUARDAR.OnHoverTextColor = System.Drawing.Color.White;
            this.BTNGUARDAR.selected = false;
            this.BTNGUARDAR.Size = new System.Drawing.Size(177, 52);
            this.BTNGUARDAR.TabIndex = 91;
            this.BTNGUARDAR.Text = "GUARDAR";
            this.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNGUARDAR.Textcolor = System.Drawing.Color.White;
            this.BTNGUARDAR.TextFont = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGUARDAR.Click += new System.EventHandler(this.BTNGUARDAR_Click_1);
            // 
            // BTNEDITAR
            // 
            this.BTNEDITAR.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNEDITAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNEDITAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNEDITAR.BorderRadius = 7;
            this.BTNEDITAR.ButtonText = "EDITAR";
            this.BTNEDITAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNEDITAR.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNEDITAR.Iconcolor = System.Drawing.Color.Transparent;
            this.BTNEDITAR.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTNEDITAR.Iconimage")));
            this.BTNEDITAR.Iconimage_right = null;
            this.BTNEDITAR.Iconimage_right_Selected = null;
            this.BTNEDITAR.Iconimage_Selected = null;
            this.BTNEDITAR.IconMarginLeft = 0;
            this.BTNEDITAR.IconMarginRight = 0;
            this.BTNEDITAR.IconRightVisible = true;
            this.BTNEDITAR.IconRightZoom = 0D;
            this.BTNEDITAR.IconVisible = true;
            this.BTNEDITAR.IconZoom = 90D;
            this.BTNEDITAR.IsTab = false;
            this.BTNEDITAR.Location = new System.Drawing.Point(94, 587);
            this.BTNEDITAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNEDITAR.Name = "BTNEDITAR";
            this.BTNEDITAR.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNEDITAR.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNEDITAR.OnHoverTextColor = System.Drawing.Color.White;
            this.BTNEDITAR.selected = false;
            this.BTNEDITAR.Size = new System.Drawing.Size(177, 52);
            this.BTNEDITAR.TabIndex = 90;
            this.BTNEDITAR.Text = "EDITAR";
            this.BTNEDITAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNEDITAR.Textcolor = System.Drawing.Color.White;
            this.BTNEDITAR.TextFont = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEDITAR.Click += new System.EventHandler(this.BTNEDITAR_Click);
            // 
            // txtsede
            // 
            this.txtsede.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.txtsede.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtsede.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.txtsede.BorderThickness = 3;
            this.txtsede.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsede.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsede.ForeColor = System.Drawing.Color.DimGray;
            this.txtsede.isPassword = false;
            this.txtsede.Location = new System.Drawing.Point(10, 516);
            this.txtsede.Margin = new System.Windows.Forms.Padding(5);
            this.txtsede.Name = "txtsede";
            this.txtsede.Size = new System.Drawing.Size(326, 45);
            this.txtsede.TabIndex = 84;
            this.txtsede.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtcorreosec
            // 
            this.txtcorreosec.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.txtcorreosec.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtcorreosec.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.txtcorreosec.BorderThickness = 3;
            this.txtcorreosec.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcorreosec.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreosec.ForeColor = System.Drawing.Color.DimGray;
            this.txtcorreosec.isPassword = false;
            this.txtcorreosec.Location = new System.Drawing.Point(10, 440);
            this.txtcorreosec.Margin = new System.Windows.Forms.Padding(5);
            this.txtcorreosec.Name = "txtcorreosec";
            this.txtcorreosec.Size = new System.Drawing.Size(326, 45);
            this.txtcorreosec.TabIndex = 83;
            this.txtcorreosec.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtcorreo
            // 
            this.txtcorreo.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.txtcorreo.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtcorreo.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.txtcorreo.BorderThickness = 3;
            this.txtcorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcorreo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.ForeColor = System.Drawing.Color.DimGray;
            this.txtcorreo.isPassword = false;
            this.txtcorreo.Location = new System.Drawing.Point(10, 364);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(5);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(326, 45);
            this.txtcorreo.TabIndex = 82;
            this.txtcorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtdireccion
            // 
            this.txtdireccion.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.txtdireccion.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtdireccion.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.txtdireccion.BorderThickness = 3;
            this.txtdireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdireccion.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.ForeColor = System.Drawing.Color.DimGray;
            this.txtdireccion.isPassword = false;
            this.txtdireccion.Location = new System.Drawing.Point(9, 288);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(5);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(326, 45);
            this.txtdireccion.TabIndex = 81;
            this.txtdireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txttelefono
            // 
            this.txttelefono.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.txttelefono.BorderColorIdle = System.Drawing.Color.Silver;
            this.txttelefono.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.txttelefono.BorderThickness = 3;
            this.txttelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttelefono.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.ForeColor = System.Drawing.Color.DimGray;
            this.txttelefono.isPassword = false;
            this.txttelefono.Location = new System.Drawing.Point(9, 212);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(5);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(326, 45);
            this.txttelefono.TabIndex = 80;
            this.txttelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtapellidos
            // 
            this.txtapellidos.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.txtapellidos.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtapellidos.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.txtapellidos.BorderThickness = 3;
            this.txtapellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtapellidos.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellidos.ForeColor = System.Drawing.Color.DimGray;
            this.txtapellidos.isPassword = false;
            this.txtapellidos.Location = new System.Drawing.Point(7, 136);
            this.txtapellidos.Margin = new System.Windows.Forms.Padding(5);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(326, 45);
            this.txtapellidos.TabIndex = 79;
            this.txtapellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtnombre
            // 
            this.txtnombre.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.txtnombre.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtnombre.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.txtnombre.BorderThickness = 3;
            this.txtnombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombre.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtnombre.isPassword = false;
            this.txtnombre.Location = new System.Drawing.Point(7, 60);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(5);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(326, 45);
            this.txtnombre.TabIndex = 78;
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // USERIMAGE
            // 
            this.USERIMAGE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.USERIMAGE.Image = ((System.Drawing.Image)(resources.GetObject("USERIMAGE.Image")));
            this.USERIMAGE.Location = new System.Drawing.Point(127, 189);
            this.USERIMAGE.Name = "USERIMAGE";
            this.USERIMAGE.Size = new System.Drawing.Size(391, 257);
            this.USERIMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.USERIMAGE.TabIndex = 24;
            this.USERIMAGE.TabStop = false;
            // 
            // lbUSER
            // 
            this.lbUSER.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUSER.Font = new System.Drawing.Font("Bahnschrift", 20.25F);
            this.lbUSER.Location = new System.Drawing.Point(175, 493);
            this.lbUSER.Name = "lbUSER";
            this.lbUSER.Size = new System.Drawing.Size(300, 33);
            this.lbUSER.TabIndex = 25;
            this.lbUSER.Text = "BIENVENIDO, USUARIO: ";
            this.lbUSER.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Size = new System.Drawing.Size(1066, 761);
            this.shapeContainer1.TabIndex = 79;
            this.shapeContainer1.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(457, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 33);
            this.label7.TabIndex = 77;
            this.label7.Text = "MI PERFIL: ";
            // 
            // LBCARRERA
            // 
            this.LBCARRERA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LBCARRERA.Font = new System.Drawing.Font("Bahnschrift", 20.25F);
            this.LBCARRERA.Location = new System.Drawing.Point(66, 595);
            this.LBCARRERA.Name = "LBCARRERA";
            this.LBCARRERA.Size = new System.Drawing.Size(508, 138);
            this.LBCARRERA.TabIndex = 80;
            this.LBCARRERA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 761);
            this.Controls.Add(this.LBCARRERA);
            this.Controls.Add(this.lbUSER);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.USERIMAGE);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Perfil";
            this.Text = "S";
            this.Load += new System.EventHandler(this.Perfil_Load);
            this.Controls.SetChildIndex(this.shapeContainer1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.USERIMAGE, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.PanelArriba, 0);
            this.Controls.SetChildIndex(this.lbUSER, 0);
            this.Controls.SetChildIndex(this.LBCARRERA, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.USERIMAGE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox USERIMAGE;
        private System.Windows.Forms.Label lbUSER;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtsede;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtcorreosec;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtcorreo;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtdireccion;
        private Bunifu.Framework.UI.BunifuMetroTextbox txttelefono;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtapellidos;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtnombre;
        private Bunifu.Framework.UI.BunifuFlatButton BTNEDITAR;
        private Bunifu.Framework.UI.BunifuFlatButton BTNGUARDAR;
        private System.Windows.Forms.Label LBCARRERA;
    }
}