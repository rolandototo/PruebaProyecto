namespace CAPAPRESENTACION
{
    partial class FormSucces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSucces));
            this.Esclarecerfrom = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnaceptar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.LBTitulo = new System.Windows.Forms.Label();
            this.PanelArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelArriba
            // 
            this.PanelArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.PanelArriba.Controls.Add(this.pictureBox1);
            this.PanelArriba.Size = new System.Drawing.Size(355, 206);
            // 
            // Esclarecerfrom
            // 
            this.Esclarecerfrom.Delay = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnaceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
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
            this.btnaceptar.Location = new System.Drawing.Point(63, 408);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnaceptar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(188)))), ((int)(((byte)(155)))));
            this.btnaceptar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnaceptar.selected = false;
            this.btnaceptar.Size = new System.Drawing.Size(212, 48);
            this.btnaceptar.TabIndex = 4;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnaceptar.Textcolor = System.Drawing.Color.White;
            this.btnaceptar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(30, 323);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(288, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "Accion completada Correctamente,\r\nPuede seguir usando el Sistema";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBTitulo
            // 
            this.LBTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LBTitulo.Location = new System.Drawing.Point(34, 234);
            this.LBTitulo.Name = "LBTitulo";
            this.LBTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LBTitulo.Size = new System.Drawing.Size(284, 44);
            this.LBTitulo.TabIndex = 6;
            this.LBTitulo.Text = "Mensaje";
            this.LBTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSucces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 484);
            this.Controls.Add(this.LBTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnaceptar);
            this.Name = "FormSucces";
            this.Text = "FormSucces";
            this.Load += new System.EventHandler(this.FormSucces_Load);
            this.Controls.SetChildIndex(this.PanelArriba, 0);
            this.Controls.SetChildIndex(this.btnaceptar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.LBTitulo, 0);
            this.PanelArriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFormFadeTransition Esclarecerfrom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnaceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBTitulo;
    }
}