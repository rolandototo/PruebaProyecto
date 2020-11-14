namespace CAPAPRESENTACION
{
    partial class HORARIOSGRUPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HORARIOSGRUPOS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LBTITULO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNTINSCRIBIR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.FADE = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.BTNCALCELAR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.GRIDhorarios = new System.Windows.Forms.DataGridView();
            this.GridCupos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNUPDATE = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.LBPRIMERO = new System.Windows.Forms.Label();
            this.TXTNOMGRUPO = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TXTMAESTRO = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDhorarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCupos)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelArriba
            // 
            this.PanelArriba.Size = new System.Drawing.Size(948, 100);
            // 
            // LBTITULO
            // 
            this.LBTITULO.AutoSize = true;
            this.LBTITULO.BackColor = System.Drawing.Color.White;
            this.LBTITULO.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.LBTITULO.ForeColor = System.Drawing.Color.Gray;
            this.LBTITULO.Location = new System.Drawing.Point(263, 127);
            this.LBTITULO.Name = "LBTITULO";
            this.LBTITULO.Size = new System.Drawing.Size(82, 19);
            this.LBTITULO.TabIndex = 58;
            this.LBTITULO.Text = "HORARIO: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 19);
            this.label1.TabIndex = 60;
            this.label1.Text = "NOMBRE DEL GRUPO";
            // 
            // BTNTINSCRIBIR
            // 
            this.BTNTINSCRIBIR.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNTINSCRIBIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNTINSCRIBIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNTINSCRIBIR.BorderRadius = 7;
            this.BTNTINSCRIBIR.ButtonText = "INSCRIBIR";
            this.BTNTINSCRIBIR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNTINSCRIBIR.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNTINSCRIBIR.Iconcolor = System.Drawing.Color.Transparent;
            this.BTNTINSCRIBIR.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTNTINSCRIBIR.Iconimage")));
            this.BTNTINSCRIBIR.Iconimage_right = null;
            this.BTNTINSCRIBIR.Iconimage_right_Selected = null;
            this.BTNTINSCRIBIR.Iconimage_Selected = null;
            this.BTNTINSCRIBIR.IconMarginLeft = 0;
            this.BTNTINSCRIBIR.IconMarginRight = 0;
            this.BTNTINSCRIBIR.IconRightVisible = true;
            this.BTNTINSCRIBIR.IconRightZoom = 0D;
            this.BTNTINSCRIBIR.IconVisible = true;
            this.BTNTINSCRIBIR.IconZoom = 90D;
            this.BTNTINSCRIBIR.IsTab = false;
            this.BTNTINSCRIBIR.Location = new System.Drawing.Point(32, 342);
            this.BTNTINSCRIBIR.Name = "BTNTINSCRIBIR";
            this.BTNTINSCRIBIR.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNTINSCRIBIR.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNTINSCRIBIR.OnHoverTextColor = System.Drawing.Color.White;
            this.BTNTINSCRIBIR.selected = false;
            this.BTNTINSCRIBIR.Size = new System.Drawing.Size(174, 48);
            this.BTNTINSCRIBIR.TabIndex = 62;
            this.BTNTINSCRIBIR.Text = "INSCRIBIR";
            this.BTNTINSCRIBIR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNTINSCRIBIR.Textcolor = System.Drawing.Color.White;
            this.BTNTINSCRIBIR.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.BTNTINSCRIBIR.Click += new System.EventHandler(this.BTNTINSCRIBIR_Click);
            // 
            // FADE
            // 
            this.FADE.Delay = 1;
            // 
            // BTNCALCELAR
            // 
            this.BTNCALCELAR.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNCALCELAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNCALCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNCALCELAR.BorderRadius = 7;
            this.BTNCALCELAR.ButtonText = "CANCELAR";
            this.BTNCALCELAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNCALCELAR.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNCALCELAR.Iconcolor = System.Drawing.Color.Transparent;
            this.BTNCALCELAR.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTNCALCELAR.Iconimage")));
            this.BTNCALCELAR.Iconimage_right = null;
            this.BTNCALCELAR.Iconimage_right_Selected = null;
            this.BTNCALCELAR.Iconimage_Selected = null;
            this.BTNCALCELAR.IconMarginLeft = 0;
            this.BTNCALCELAR.IconMarginRight = 0;
            this.BTNCALCELAR.IconRightVisible = true;
            this.BTNCALCELAR.IconRightZoom = 0D;
            this.BTNCALCELAR.IconVisible = true;
            this.BTNCALCELAR.IconZoom = 90D;
            this.BTNCALCELAR.IsTab = false;
            this.BTNCALCELAR.Location = new System.Drawing.Point(32, 396);
            this.BTNCALCELAR.Name = "BTNCALCELAR";
            this.BTNCALCELAR.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNCALCELAR.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNCALCELAR.OnHoverTextColor = System.Drawing.Color.White;
            this.BTNCALCELAR.selected = false;
            this.BTNCALCELAR.Size = new System.Drawing.Size(174, 48);
            this.BTNCALCELAR.TabIndex = 63;
            this.BTNCALCELAR.Text = "CANCELAR";
            this.BTNCALCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNCALCELAR.Textcolor = System.Drawing.Color.White;
            this.BTNCALCELAR.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.BTNCALCELAR.Click += new System.EventHandler(this.BTNCALCELAR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(12, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 66;
            this.label2.Text = "MAESTRO";
            // 
            // GRIDhorarios
            // 
            this.GRIDhorarios.AllowUserToAddRows = false;
            this.GRIDhorarios.AllowUserToDeleteRows = false;
            this.GRIDhorarios.AllowUserToOrderColumns = true;
            this.GRIDhorarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GRIDhorarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GRIDhorarios.BackgroundColor = System.Drawing.Color.White;
            this.GRIDhorarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GRIDhorarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GRIDhorarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GRIDhorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDhorarios.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRIDhorarios.DefaultCellStyle = dataGridViewCellStyle1;
            this.GRIDhorarios.Location = new System.Drawing.Point(267, 150);
            this.GRIDhorarios.Name = "GRIDhorarios";
            this.GRIDhorarios.ReadOnly = true;
            this.GRIDhorarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GRIDhorarios.RowHeadersVisible = false;
            this.GRIDhorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GRIDhorarios.Size = new System.Drawing.Size(642, 84);
            this.GRIDhorarios.TabIndex = 67;
            // 
            // GridCupos
            // 
            this.GridCupos.AllowUserToAddRows = false;
            this.GridCupos.AllowUserToDeleteRows = false;
            this.GridCupos.AllowUserToOrderColumns = true;
            this.GridCupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridCupos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridCupos.BackgroundColor = System.Drawing.Color.White;
            this.GridCupos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridCupos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridCupos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridCupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCupos.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridCupos.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridCupos.Location = new System.Drawing.Point(267, 284);
            this.GridCupos.Name = "GridCupos";
            this.GridCupos.ReadOnly = true;
            this.GridCupos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridCupos.RowHeadersVisible = false;
            this.GridCupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridCupos.Size = new System.Drawing.Size(642, 56);
            this.GridCupos.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(633, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 19);
            this.label4.TabIndex = 70;
            this.label4.Text = "INSCRITOS ACTUALMENTE";
            // 
            // BTNUPDATE
            // 
            this.BTNUPDATE.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNUPDATE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNUPDATE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNUPDATE.BorderRadius = 7;
            this.BTNUPDATE.ButtonText = "ACTUALIZAR";
            this.BTNUPDATE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNUPDATE.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNUPDATE.Iconcolor = System.Drawing.Color.Transparent;
            this.BTNUPDATE.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTNUPDATE.Iconimage")));
            this.BTNUPDATE.Iconimage_right = null;
            this.BTNUPDATE.Iconimage_right_Selected = null;
            this.BTNUPDATE.Iconimage_Selected = null;
            this.BTNUPDATE.IconMarginLeft = 0;
            this.BTNUPDATE.IconMarginRight = 0;
            this.BTNUPDATE.IconRightVisible = true;
            this.BTNUPDATE.IconRightZoom = 0D;
            this.BTNUPDATE.IconVisible = true;
            this.BTNUPDATE.IconZoom = 90D;
            this.BTNUPDATE.IsTab = false;
            this.BTNUPDATE.Location = new System.Drawing.Point(742, 369);
            this.BTNUPDATE.Name = "BTNUPDATE";
            this.BTNUPDATE.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNUPDATE.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNUPDATE.OnHoverTextColor = System.Drawing.Color.White;
            this.BTNUPDATE.selected = false;
            this.BTNUPDATE.Size = new System.Drawing.Size(167, 48);
            this.BTNUPDATE.TabIndex = 72;
            this.BTNUPDATE.Text = "ACTUALIZAR";
            this.BTNUPDATE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNUPDATE.Textcolor = System.Drawing.Color.White;
            this.BTNUPDATE.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.BTNUPDATE.Click += new System.EventHandler(this.BTNUPDATE_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(341, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 73;
            this.label3.Text = "CUPO MAXIMO ";
            // 
            // LBPRIMERO
            // 
            this.LBPRIMERO.BackColor = System.Drawing.Color.White;
            this.LBPRIMERO.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Bold);
            this.LBPRIMERO.ForeColor = System.Drawing.Color.Gray;
            this.LBPRIMERO.Location = new System.Drawing.Point(345, 242);
            this.LBPRIMERO.Name = "LBPRIMERO";
            this.LBPRIMERO.Size = new System.Drawing.Size(487, 101);
            this.LBPRIMERO.TabIndex = 74;
            this.LBPRIMERO.Text = "\"NO SE HA REGISTRADO NADIE PARA ESTE GRUPO, SE EL PRIMERO!\"";
            this.LBPRIMERO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXTNOMGRUPO
            // 
            this.TXTNOMGRUPO.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.TXTNOMGRUPO.BorderColorIdle = System.Drawing.Color.Silver;
            this.TXTNOMGRUPO.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.TXTNOMGRUPO.BorderThickness = 3;
            this.TXTNOMGRUPO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTNOMGRUPO.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNOMGRUPO.ForeColor = System.Drawing.Color.DimGray;
            this.TXTNOMGRUPO.isPassword = false;
            this.TXTNOMGRUPO.Location = new System.Drawing.Point(16, 197);
            this.TXTNOMGRUPO.Margin = new System.Windows.Forms.Padding(5);
            this.TXTNOMGRUPO.Name = "TXTNOMGRUPO";
            this.TXTNOMGRUPO.Size = new System.Drawing.Size(231, 37);
            this.TXTNOMGRUPO.TabIndex = 79;
            this.TXTNOMGRUPO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TXTMAESTRO
            // 
            this.TXTMAESTRO.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.TXTMAESTRO.BorderColorIdle = System.Drawing.Color.Silver;
            this.TXTMAESTRO.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.TXTMAESTRO.BorderThickness = 3;
            this.TXTMAESTRO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTMAESTRO.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTMAESTRO.ForeColor = System.Drawing.Color.DimGray;
            this.TXTMAESTRO.isPassword = false;
            this.TXTMAESTRO.Location = new System.Drawing.Point(16, 266);
            this.TXTMAESTRO.Margin = new System.Windows.Forms.Padding(5);
            this.TXTMAESTRO.Name = "TXTMAESTRO";
            this.TXTMAESTRO.Size = new System.Drawing.Size(231, 37);
            this.TXTMAESTRO.TabIndex = 80;
            this.TXTMAESTRO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // HORARIOSGRUPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 473);
            this.Controls.Add(this.TXTMAESTRO);
            this.Controls.Add(this.TXTNOMGRUPO);
            this.Controls.Add(this.LBPRIMERO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTNUPDATE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GridCupos);
            this.Controls.Add(this.GRIDhorarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTNCALCELAR);
            this.Controls.Add(this.BTNTINSCRIBIR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBTITULO);
            this.Name = "HORARIOSGRUPOS";
            this.Text = "HORARIOSGRUPOS";
            this.Load += new System.EventHandler(this.HORARIOSGRUPOS_Load);
            this.Controls.SetChildIndex(this.PanelArriba, 0);
            this.Controls.SetChildIndex(this.LBTITULO, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.BTNTINSCRIBIR, 0);
            this.Controls.SetChildIndex(this.BTNCALCELAR, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.GRIDhorarios, 0);
            this.Controls.SetChildIndex(this.GridCupos, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.BTNUPDATE, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.LBPRIMERO, 0);
            this.Controls.SetChildIndex(this.TXTNOMGRUPO, 0);
            this.Controls.SetChildIndex(this.TXTMAESTRO, 0);
            ((System.ComponentModel.ISupportInitialize)(this.GRIDhorarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBTITULO;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton BTNTINSCRIBIR;
        private Bunifu.Framework.UI.BunifuFormFadeTransition FADE;
        private Bunifu.Framework.UI.BunifuFlatButton BTNCALCELAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GRIDhorarios;
        private System.Windows.Forms.DataGridView GridCupos;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton BTNUPDATE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBPRIMERO;
        public Bunifu.Framework.UI.BunifuMetroTextbox TXTNOMGRUPO;
        public Bunifu.Framework.UI.BunifuMetroTextbox TXTMAESTRO;
    }
}