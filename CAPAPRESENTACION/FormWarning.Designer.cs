namespace CAPAPRESENTACION
{
    partial class FormWarning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWarning));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBMensaje = new System.Windows.Forms.Label();
            this.LBTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnaceptar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.esclarecer = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.PanelArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelArriba
            // 
            this.PanelArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(42)))), ((int)(((byte)(66)))));
            this.PanelArriba.Controls.Add(this.label2);
            this.PanelArriba.Controls.Add(this.pictureBox1);
            this.PanelArriba.Size = new System.Drawing.Size(418, 169);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LBMensaje
            // 
            this.LBMensaje.BackColor = System.Drawing.Color.Transparent;
            this.LBMensaje.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMensaje.ForeColor = System.Drawing.Color.Gray;
            this.LBMensaje.Location = new System.Drawing.Point(12, 305);
            this.LBMensaje.Name = "LBMensaje";
            this.LBMensaje.Size = new System.Drawing.Size(387, 167);
            this.LBMensaje.TabIndex = 61;
            this.LBMensaje.Text = "MENSAJE";
            this.LBMensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBTitulo
            // 
            this.LBTitulo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTitulo.Location = new System.Drawing.Point(12, 185);
            this.LBTitulo.Name = "LBTitulo";
            this.LBTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LBTitulo.Size = new System.Drawing.Size(387, 103);
            this.LBTitulo.TabIndex = 60;
            this.LBTitulo.Text = "TITULO";
            this.LBTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(228, 67);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(119, 44);
            this.label2.TabIndex = 8;
            this.label2.Text = "AVISO!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnaceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(42)))), ((int)(((byte)(66)))));
            this.btnaceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnaceptar.BorderRadius = 7;
            this.btnaceptar.ButtonText = "Aceptar";
            this.btnaceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaceptar.DisabledColor = System.Drawing.Color.Gray;
            this.btnaceptar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnaceptar.Iconimage = null;
            this.btnaceptar.Iconimage_right = null;
            this.btnaceptar.Iconimage_right_Selected = null;
            this.btnaceptar.Iconimage_Selected = null;
            this.btnaceptar.IconMarginLeft = 0;
            this.btnaceptar.IconMarginRight = 0;
            this.btnaceptar.IconRightVisible = true;
            this.btnaceptar.IconRightZoom = 0D;
            this.btnaceptar.IconVisible = true;
            this.btnaceptar.IconZoom = 90D;
            this.btnaceptar.IsTab = false;
            this.btnaceptar.Location = new System.Drawing.Point(153, 475);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnaceptar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btnaceptar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnaceptar.selected = false;
            this.btnaceptar.Size = new System.Drawing.Size(103, 48);
            this.btnaceptar.TabIndex = 62;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnaceptar.Textcolor = System.Drawing.Color.White;
            this.btnaceptar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // esclarecer
            // 
            this.esclarecer.Delay = 1;
            // 
            // FormWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 530);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.LBMensaje);
            this.Controls.Add(this.LBTitulo);
            this.Name = "FormWarning";
            this.Text = "FormWarning";
            this.Load += new System.EventHandler(this.FormWarning_Load);
            this.Controls.SetChildIndex(this.PanelArriba, 0);
            this.Controls.SetChildIndex(this.LBTitulo, 0);
            this.Controls.SetChildIndex(this.LBMensaje, 0);
            this.Controls.SetChildIndex(this.btnaceptar, 0);
            this.PanelArriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBMensaje;
        private System.Windows.Forms.Label LBTitulo;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnaceptar;
        private Bunifu.Framework.UI.BunifuFormFadeTransition esclarecer;
    }
}