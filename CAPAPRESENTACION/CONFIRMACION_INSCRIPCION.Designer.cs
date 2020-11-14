namespace CAPAPRESENTACION
{
    partial class CONFIRMACION_INSCRIPCION
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CONFIRMACION_INSCRIPCION));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNguardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txttotalpagar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcuota = new System.Windows.Forms.TextBox();
            this.btncancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Esclarecer = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelArriba
            // 
            this.PanelArriba.Size = new System.Drawing.Size(573, 54);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTNguardar);
            this.groupBox1.Controls.Add(this.txttotalpagar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtcuota);
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(37, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 313);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMACION DE PAGO";
            // 
            // BTNguardar
            // 
            this.BTNguardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNguardar.BorderRadius = 7;
            this.BTNguardar.ButtonText = "GUARDAR";
            this.BTNguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNguardar.DisabledColor = System.Drawing.Color.Gray;
            this.BTNguardar.Iconcolor = System.Drawing.Color.Transparent;
            this.BTNguardar.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTNguardar.Iconimage")));
            this.BTNguardar.Iconimage_right = null;
            this.BTNguardar.Iconimage_right_Selected = null;
            this.BTNguardar.Iconimage_Selected = null;
            this.BTNguardar.IconMarginLeft = 0;
            this.BTNguardar.IconMarginRight = 0;
            this.BTNguardar.IconRightVisible = true;
            this.BTNguardar.IconRightZoom = 0D;
            this.BTNguardar.IconVisible = true;
            this.BTNguardar.IconZoom = 90D;
            this.BTNguardar.IsTab = false;
            this.BTNguardar.Location = new System.Drawing.Point(23, 205);
            this.BTNguardar.Name = "BTNguardar";
            this.BTNguardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNguardar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNguardar.OnHoverTextColor = System.Drawing.Color.White;
            this.BTNguardar.selected = false;
            this.BTNguardar.Size = new System.Drawing.Size(259, 38);
            this.BTNguardar.TabIndex = 56;
            this.BTNguardar.Text = "GUARDAR";
            this.BTNguardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTNguardar.Textcolor = System.Drawing.Color.White;
            this.BTNguardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.BTNguardar.Click += new System.EventHandler(this.BTNguardar_Click);
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.Location = new System.Drawing.Point(7, 156);
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.Size = new System.Drawing.Size(292, 26);
            this.txttotalpagar.TabIndex = 3;
            this.txttotalpagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "MONTO A PAGAR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "SU CUOTA";
            // 
            // txtcuota
            // 
            this.txtcuota.Location = new System.Drawing.Point(6, 75);
            this.txtcuota.Name = "txtcuota";
            this.txtcuota.Size = new System.Drawing.Size(292, 26);
            this.txtcuota.TabIndex = 0;
            this.txtcuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btncancelar
            // 
            this.btncancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.BorderRadius = 7;
            this.btncancelar.ButtonText = "CANCELAR";
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.DisabledColor = System.Drawing.Color.Gray;
            this.btncancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btncancelar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btncancelar.Iconimage")));
            this.btncancelar.Iconimage_right = null;
            this.btncancelar.Iconimage_right_Selected = null;
            this.btncancelar.Iconimage_Selected = null;
            this.btncancelar.IconMarginLeft = 0;
            this.btncancelar.IconMarginRight = 0;
            this.btncancelar.IconRightVisible = true;
            this.btncancelar.IconRightZoom = 0D;
            this.btncancelar.IconVisible = true;
            this.btncancelar.IconZoom = 90D;
            this.btncancelar.IsTab = false;
            this.btncancelar.Location = new System.Drawing.Point(23, 260);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btncancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.btncancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btncancelar.selected = false;
            this.btncancelar.Size = new System.Drawing.Size(259, 35);
            this.btncancelar.TabIndex = 57;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncancelar.Textcolor = System.Drawing.Color.White;
            this.btncancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.btncancelar.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // Esclarecer
            // 
            this.Esclarecer.Delay = 1;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(33, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(495, 59);
            this.label5.TabIndex = 72;
            this.label5.Text = "\"AL MOMENTO DE DARLE A GUARDAR TENDRA 24H PARA CANCELAR (INICIE EL PROCESO SOLO S" +
    "I ESTA SEGURO)\r\n,SI TIENE ALGUN PROBLEMA CON SU CUOTA ,CONTACTE A SOPORTE TECNIC" +
    "O\"";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(348, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 253);
            this.label4.TabIndex = 73;
            this.label4.Text = "\"SI TIENE ALGUN RECLAMO SOBRE SU CUOTA , POR FAVOR CONTACTESE\r\nCON SOPORTE TECNIC" +
    "O ANTES DE INICIAR EL PROCESO.\"";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CONFIRMACION_INSCRIPCION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 468);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "CONFIRMACION_INSCRIPCION";
            this.Text = "CONFIRMACION_INSCRIPCION";
            this.Load += new System.EventHandler(this.CONFIRMACION_INSCRIPCION_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.PanelArriba, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttotalpagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcuota;
        private Bunifu.Framework.UI.BunifuFlatButton BTNguardar;
        private Bunifu.Framework.UI.BunifuFlatButton btncancelar;
        private Bunifu.Framework.UI.BunifuFormFadeTransition Esclarecer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}