namespace CAPAPRESENTACION
{
    partial class Notas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notas));
            this.CBMMATERIAS = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GRIDActiva = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LBTITULO = new System.Windows.Forms.Label();
            this.BTNACTUALIZARGIRD = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LBPROMEDIO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDActiva)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelArriba
            // 
            this.PanelArriba.Size = new System.Drawing.Size(1066, 67);
            // 
            // CBMMATERIAS
            // 
            this.CBMMATERIAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBMMATERIAS.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMMATERIAS.FormattingEnabled = true;
            this.CBMMATERIAS.Location = new System.Drawing.Point(322, 124);
            this.CBMMATERIAS.Name = "CBMMATERIAS";
            this.CBMMATERIAS.Size = new System.Drawing.Size(462, 26);
            this.CBMMATERIAS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(453, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 33);
            this.label1.TabIndex = 77;
            this.label1.Text = "MIS NOTAS: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(196, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 82;
            this.label7.Text = "MATERIAS ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(420, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 83;
            this.label2.Text = "DETALLE DE NOTAS";
            // 
            // GRIDActiva
            // 
            this.GRIDActiva.AllowUserToAddRows = false;
            this.GRIDActiva.AllowUserToDeleteRows = false;
            this.GRIDActiva.AllowUserToOrderColumns = true;
            this.GRIDActiva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GRIDActiva.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GRIDActiva.BackgroundColor = System.Drawing.Color.White;
            this.GRIDActiva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GRIDActiva.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GRIDActiva.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRIDActiva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GRIDActiva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDActiva.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRIDActiva.DefaultCellStyle = dataGridViewCellStyle2;
            this.GRIDActiva.Location = new System.Drawing.Point(19, 293);
            this.GRIDActiva.Name = "GRIDActiva";
            this.GRIDActiva.ReadOnly = true;
            this.GRIDActiva.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GRIDActiva.RowHeadersVisible = false;
            this.GRIDActiva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GRIDActiva.Size = new System.Drawing.Size(1028, 294);
            this.GRIDActiva.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(147, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 85;
            this.label3.Text = "EVALUACION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(491, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 86;
            this.label4.Text = "PORCENTAJE %";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(853, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 87;
            this.label5.Text = "NOTA";
            // 
            // LBTITULO
            // 
            this.LBTITULO.AutoSize = true;
            this.LBTITULO.BackColor = System.Drawing.Color.White;
            this.LBTITULO.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTITULO.ForeColor = System.Drawing.Color.DimGray;
            this.LBTITULO.Location = new System.Drawing.Point(497, 625);
            this.LBTITULO.Name = "LBTITULO";
            this.LBTITULO.Size = new System.Drawing.Size(309, 33);
            this.LBTITULO.TabIndex = 88;
            this.LBTITULO.Text = "NOTA FINAL PROMEDIO: ";
            // 
            // BTNACTUALIZARGIRD
            // 
            this.BTNACTUALIZARGIRD.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNACTUALIZARGIRD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNACTUALIZARGIRD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNACTUALIZARGIRD.BorderRadius = 7;
            this.BTNACTUALIZARGIRD.ButtonText = "ACTUALIZAR";
            this.BTNACTUALIZARGIRD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNACTUALIZARGIRD.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNACTUALIZARGIRD.Iconcolor = System.Drawing.Color.Transparent;
            this.BTNACTUALIZARGIRD.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTNACTUALIZARGIRD.Iconimage")));
            this.BTNACTUALIZARGIRD.Iconimage_right = null;
            this.BTNACTUALIZARGIRD.Iconimage_right_Selected = null;
            this.BTNACTUALIZARGIRD.Iconimage_Selected = null;
            this.BTNACTUALIZARGIRD.IconMarginLeft = 0;
            this.BTNACTUALIZARGIRD.IconMarginRight = 0;
            this.BTNACTUALIZARGIRD.IconRightVisible = true;
            this.BTNACTUALIZARGIRD.IconRightZoom = 0D;
            this.BTNACTUALIZARGIRD.IconVisible = true;
            this.BTNACTUALIZARGIRD.IconZoom = 90D;
            this.BTNACTUALIZARGIRD.IsTab = false;
            this.BTNACTUALIZARGIRD.Location = new System.Drawing.Point(824, 176);
            this.BTNACTUALIZARGIRD.Name = "BTNACTUALIZARGIRD";
            this.BTNACTUALIZARGIRD.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNACTUALIZARGIRD.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNACTUALIZARGIRD.OnHoverTextColor = System.Drawing.Color.White;
            this.BTNACTUALIZARGIRD.selected = false;
            this.BTNACTUALIZARGIRD.Size = new System.Drawing.Size(174, 48);
            this.BTNACTUALIZARGIRD.TabIndex = 89;
            this.BTNACTUALIZARGIRD.Text = "ACTUALIZAR";
            this.BTNACTUALIZARGIRD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNACTUALIZARGIRD.Textcolor = System.Drawing.Color.White;
            this.BTNACTUALIZARGIRD.TextFont = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNACTUALIZARGIRD.Click += new System.EventHandler(this.BTNACTUALIZARGIRD_Click);
            // 
            // LBPROMEDIO
            // 
            this.LBPROMEDIO.BackColor = System.Drawing.Color.White;
            this.LBPROMEDIO.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPROMEDIO.ForeColor = System.Drawing.Color.DimGray;
            this.LBPROMEDIO.Location = new System.Drawing.Point(812, 625);
            this.LBPROMEDIO.Name = "LBPROMEDIO";
            this.LBPROMEDIO.Size = new System.Drawing.Size(89, 33);
            this.LBPROMEDIO.TabIndex = 90;
            // 
            // Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 761);
            this.Controls.Add(this.LBPROMEDIO);
            this.Controls.Add(this.BTNACTUALIZARGIRD);
            this.Controls.Add(this.LBTITULO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GRIDActiva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBMMATERIAS);
            this.Name = "Notas";
            this.Text = "Notas";
            this.Load += new System.EventHandler(this.Notas_Load);
            this.Controls.SetChildIndex(this.CBMMATERIAS, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.GRIDActiva, 0);
            this.Controls.SetChildIndex(this.PanelArriba, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.LBTITULO, 0);
            this.Controls.SetChildIndex(this.BTNACTUALIZARGIRD, 0);
            this.Controls.SetChildIndex(this.LBPROMEDIO, 0);
            ((System.ComponentModel.ISupportInitialize)(this.GRIDActiva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBMMATERIAS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GRIDActiva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBTITULO;
        private Bunifu.Framework.UI.BunifuFlatButton BTNACTUALIZARGIRD;
        private System.Windows.Forms.Label LBPROMEDIO;
    }
}