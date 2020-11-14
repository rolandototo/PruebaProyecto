namespace CAPAPRESENTACION
{
    partial class Confirmacion_Pago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirmacion_Pago));
            this.fade = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.mover = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.BTNPAGAR = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BTNSALIR = new Bunifu.Framework.UI.BunifuThinButton2();
            this.LBTOTAL = new System.Windows.Forms.Label();
            this.TXTNUMEROTargeta = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTCVV = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.limpiarlabel = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.PanelArriba.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelArriba
            // 
            this.PanelArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.PanelArriba.Controls.Add(this.LBTOTAL);
            this.PanelArriba.Controls.Add(this.BTNSALIR);
            this.PanelArriba.Controls.Add(this.BTNPAGAR);
            this.PanelArriba.Controls.Add(this.label7);
            this.PanelArriba.Size = new System.Drawing.Size(811, 185);
            // 
            // fade
            // 
            this.fade.Delay = 1;
            // 
            // mover
            // 
            this.mover.Fixed = true;
            this.mover.Horizontal = true;
            this.mover.TargetControl = this.PanelArriba;
            this.mover.Vertical = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(27, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(324, 33);
            this.label7.TabIndex = 82;
            this.label7.Text = "CONFIRMACION DE PAGO ";
            // 
            // BTNPAGAR
            // 
            this.BTNPAGAR.ActiveBorderThickness = 1;
            this.BTNPAGAR.ActiveCornerRadius = 30;
            this.BTNPAGAR.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNPAGAR.ActiveForecolor = System.Drawing.Color.White;
            this.BTNPAGAR.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNPAGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.BTNPAGAR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNPAGAR.BackgroundImage")));
            this.BTNPAGAR.ButtonText = "PAGAR";
            this.BTNPAGAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNPAGAR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPAGAR.ForeColor = System.Drawing.Color.LightGray;
            this.BTNPAGAR.IdleBorderThickness = 1;
            this.BTNPAGAR.IdleCornerRadius = 30;
            this.BTNPAGAR.IdleFillColor = System.Drawing.Color.Transparent;
            this.BTNPAGAR.IdleForecolor = System.Drawing.Color.LightGray;
            this.BTNPAGAR.IdleLineColor = System.Drawing.Color.LightGray;
            this.BTNPAGAR.Location = new System.Drawing.Point(176, 139);
            this.BTNPAGAR.Margin = new System.Windows.Forms.Padding(5);
            this.BTNPAGAR.Name = "BTNPAGAR";
            this.BTNPAGAR.Size = new System.Drawing.Size(175, 41);
            this.BTNPAGAR.TabIndex = 84;
            this.BTNPAGAR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTNPAGAR.Click += new System.EventHandler(this.BTNPAGAR_Click);
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.ActiveBorderThickness = 1;
            this.BTNSALIR.ActiveCornerRadius = 30;
            this.BTNSALIR.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNSALIR.ActiveForecolor = System.Drawing.Color.White;
            this.BTNSALIR.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNSALIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.BTNSALIR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNSALIR.BackgroundImage")));
            this.BTNSALIR.ButtonText = "SALIR";
            this.BTNSALIR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNSALIR.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALIR.ForeColor = System.Drawing.Color.LightGray;
            this.BTNSALIR.IdleBorderThickness = 1;
            this.BTNSALIR.IdleCornerRadius = 30;
            this.BTNSALIR.IdleFillColor = System.Drawing.Color.Transparent;
            this.BTNSALIR.IdleForecolor = System.Drawing.Color.LightGray;
            this.BTNSALIR.IdleLineColor = System.Drawing.Color.LightGray;
            this.BTNSALIR.Location = new System.Drawing.Point(490, 139);
            this.BTNSALIR.Margin = new System.Windows.Forms.Padding(5);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(175, 41);
            this.BTNSALIR.TabIndex = 85;
            this.BTNSALIR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTNSALIR.Click += new System.EventHandler(this.BTNSALIR_Click);
            // 
            // LBTOTAL
            // 
            this.LBTOTAL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBTOTAL.AutoSize = true;
            this.LBTOTAL.BackColor = System.Drawing.Color.Transparent;
            this.LBTOTAL.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTOTAL.ForeColor = System.Drawing.Color.LightGray;
            this.LBTOTAL.Location = new System.Drawing.Point(524, 37);
            this.LBTOTAL.Name = "LBTOTAL";
            this.LBTOTAL.Size = new System.Drawing.Size(0, 33);
            this.LBTOTAL.TabIndex = 83;
            // 
            // TXTNUMEROTargeta
            // 
            this.TXTNUMEROTargeta.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.TXTNUMEROTargeta.BorderColorIdle = System.Drawing.Color.Silver;
            this.TXTNUMEROTargeta.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.TXTNUMEROTargeta.BorderThickness = 3;
            this.TXTNUMEROTargeta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTNUMEROTargeta.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNUMEROTargeta.ForeColor = System.Drawing.Color.DimGray;
            this.TXTNUMEROTargeta.isPassword = false;
            this.TXTNUMEROTargeta.Location = new System.Drawing.Point(33, 282);
            this.TXTNUMEROTargeta.Margin = new System.Windows.Forms.Padding(5);
            this.TXTNUMEROTargeta.Name = "TXTNUMEROTargeta";
            this.TXTNUMEROTargeta.Size = new System.Drawing.Size(379, 54);
            this.TXTNUMEROTargeta.TabIndex = 1;
            this.TXTNUMEROTargeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(48, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "N# DE TARGETA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(563, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "FECHA DE VENCIMIENTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(632, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "CVV";
            // 
            // TXTCVV
            // 
            this.TXTCVV.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.TXTCVV.BorderColorIdle = System.Drawing.Color.Silver;
            this.TXTCVV.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.TXTCVV.BorderThickness = 3;
            this.TXTCVV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTCVV.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTCVV.ForeColor = System.Drawing.Color.DimGray;
            this.TXTCVV.isPassword = false;
            this.TXTCVV.Location = new System.Drawing.Point(598, 341);
            this.TXTCVV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXTCVV.Name = "TXTCVV";
            this.TXTCVV.Size = new System.Drawing.Size(114, 54);
            this.TXTCVV.TabIndex = 9;
            this.TXTCVV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // limpiarlabel
            // 
            this.limpiarlabel.AutoSize = true;
            this.limpiarlabel.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarlabel.Location = new System.Drawing.Point(155, 369);
            this.limpiarlabel.Name = "limpiarlabel";
            this.limpiarlabel.Size = new System.Drawing.Size(118, 18);
            this.limpiarlabel.TabIndex = 10;
            this.limpiarlabel.TabStop = true;
            this.limpiarlabel.Text = "Limpiar Campos";
            this.limpiarlabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.limpiarlabel_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(617, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "MM/YYYY";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Bahnschrift", 12.75F);
            this.maskedTextBox1.Location = new System.Drawing.Point(598, 269);
            this.maskedTextBox1.Mask = "00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(114, 28);
            this.maskedTextBox1.TabIndex = 13;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // Confirmacion_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 418);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.limpiarlabel);
            this.Controls.Add(this.TXTCVV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTNUMEROTargeta);
            this.Name = "Confirmacion_Pago";
            this.Text = "Confirmacion_Pago";
            this.Load += new System.EventHandler(this.Confirmacion_Pago_Load);
            this.Controls.SetChildIndex(this.PanelArriba, 0);
            this.Controls.SetChildIndex(this.TXTNUMEROTargeta, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.TXTCVV, 0);
            this.Controls.SetChildIndex(this.limpiarlabel, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.maskedTextBox1, 0);
            this.PanelArriba.ResumeLayout(false);
            this.PanelArriba.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFormFadeTransition fade;
        private Bunifu.Framework.UI.BunifuDragControl mover;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuThinButton2 BTNSALIR;
        private Bunifu.Framework.UI.BunifuThinButton2 BTNPAGAR;
        private System.Windows.Forms.Label LBTOTAL;
        private Bunifu.Framework.UI.BunifuMetroTextbox TXTNUMEROTargeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox TXTCVV;
        private System.Windows.Forms.LinkLabel limpiarlabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}