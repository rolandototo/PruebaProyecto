namespace CAPAPRESENTACION
{
    partial class Inscripcion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscripcion));
            this.label1 = new System.Windows.Forms.Label();
            this.CBMATERIAS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTNACTUALIZARGIRD = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BTNTERMINAR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.GRIDGrupos = new System.Windows.Forms.DataGridView();
            this.HORARIOS = new System.Windows.Forms.DataGridViewImageColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.LBPRUEBA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GRIDgruposinscritos = new System.Windows.Forms.DataGridView();
            this.DELETE = new System.Windows.Forms.DataGridViewImageColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BTNSALIR = new System.Windows.Forms.PictureBox();
            this.MOVERFORM = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.APARECER = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.PanelArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDgruposinscritos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNSALIR)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelArriba
            // 
            this.PanelArriba.Controls.Add(this.BTNSALIR);
            this.PanelArriba.Size = new System.Drawing.Size(1066, 60);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(166, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "MATERIAS";
            // 
            // CBMATERIAS
            // 
            this.CBMATERIAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBMATERIAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CBMATERIAS.FormattingEnabled = true;
            this.CBMATERIAS.Location = new System.Drawing.Point(263, 112);
            this.CBMATERIAS.Name = "CBMATERIAS";
            this.CBMATERIAS.Size = new System.Drawing.Size(566, 28);
            this.CBMATERIAS.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 20.25F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(353, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "PROCESO DE INSCRIPCION";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(701, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 19);
            this.label12.TabIndex = 51;
            this.label12.Text = "MAESTRO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(368, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 19);
            this.label10.TabIndex = 49;
            this.label10.Text = "NOMBRE DEL GRUPO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(918, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 52;
            this.label5.Text = "MAX. CUPO";
            // 
            // BTNACTUALIZARGIRD
            // 
            this.BTNACTUALIZARGIRD.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.BTNACTUALIZARGIRD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNACTUALIZARGIRD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNACTUALIZARGIRD.BorderRadius = 7;
            this.BTNACTUALIZARGIRD.ButtonText = "BUSCAR GRUPOS";
            this.BTNACTUALIZARGIRD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNACTUALIZARGIRD.DisabledColor = System.Drawing.Color.Gray;
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
            this.BTNACTUALIZARGIRD.Location = new System.Drawing.Point(866, 86);
            this.BTNACTUALIZARGIRD.Name = "BTNACTUALIZARGIRD";
            this.BTNACTUALIZARGIRD.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNACTUALIZARGIRD.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.BTNACTUALIZARGIRD.OnHoverTextColor = System.Drawing.Color.White;
            this.BTNACTUALIZARGIRD.selected = false;
            this.BTNACTUALIZARGIRD.Size = new System.Drawing.Size(174, 48);
            this.BTNACTUALIZARGIRD.TabIndex = 55;
            this.BTNACTUALIZARGIRD.Text = "BUSCAR GRUPOS";
            this.BTNACTUALIZARGIRD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNACTUALIZARGIRD.Textcolor = System.Drawing.Color.White;
            this.BTNACTUALIZARGIRD.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.BTNACTUALIZARGIRD.Click += new System.EventHandler(this.BTNACTUALIZARGIRD_Click);
            // 
            // BTNTERMINAR
            // 
            this.BTNTERMINAR.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNTERMINAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNTERMINAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNTERMINAR.BorderRadius = 7;
            this.BTNTERMINAR.ButtonText = "TERMINAR";
            this.BTNTERMINAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNTERMINAR.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNTERMINAR.Iconcolor = System.Drawing.Color.Transparent;
            this.BTNTERMINAR.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTNTERMINAR.Iconimage")));
            this.BTNTERMINAR.Iconimage_right = null;
            this.BTNTERMINAR.Iconimage_right_Selected = null;
            this.BTNTERMINAR.Iconimage_Selected = null;
            this.BTNTERMINAR.IconMarginLeft = 0;
            this.BTNTERMINAR.IconMarginRight = 0;
            this.BTNTERMINAR.IconRightVisible = true;
            this.BTNTERMINAR.IconRightZoom = 0D;
            this.BTNTERMINAR.IconVisible = true;
            this.BTNTERMINAR.IconZoom = 90D;
            this.BTNTERMINAR.IsTab = false;
            this.BTNTERMINAR.Location = new System.Drawing.Point(424, 706);
            this.BTNTERMINAR.Name = "BTNTERMINAR";
            this.BTNTERMINAR.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNTERMINAR.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.BTNTERMINAR.OnHoverTextColor = System.Drawing.Color.White;
            this.BTNTERMINAR.selected = false;
            this.BTNTERMINAR.Size = new System.Drawing.Size(174, 48);
            this.BTNTERMINAR.TabIndex = 61;
            this.BTNTERMINAR.Text = "TERMINAR";
            this.BTNTERMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNTERMINAR.Textcolor = System.Drawing.Color.White;
            this.BTNTERMINAR.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.BTNTERMINAR.Click += new System.EventHandler(this.BTNTERMINAR_Click);
            // 
            // GRIDGrupos
            // 
            this.GRIDGrupos.AllowUserToAddRows = false;
            this.GRIDGrupos.AllowUserToDeleteRows = false;
            this.GRIDGrupos.AllowUserToOrderColumns = true;
            this.GRIDGrupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GRIDGrupos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GRIDGrupos.BackgroundColor = System.Drawing.Color.White;
            this.GRIDGrupos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GRIDGrupos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GRIDGrupos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GRIDGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDGrupos.ColumnHeadersVisible = false;
            this.GRIDGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HORARIOS});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRIDGrupos.DefaultCellStyle = dataGridViewCellStyle3;
            this.GRIDGrupos.Location = new System.Drawing.Point(9, 181);
            this.GRIDGrupos.Name = "GRIDGrupos";
            this.GRIDGrupos.ReadOnly = true;
            this.GRIDGrupos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GRIDGrupos.RowHeadersVisible = false;
            this.GRIDGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GRIDGrupos.Size = new System.Drawing.Size(1045, 210);
            this.GRIDGrupos.TabIndex = 63;
            this.GRIDGrupos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRIDGrupos_CellContentClick);
            // 
            // HORARIOS
            // 
            this.HORARIOS.HeaderText = "HORARIOS";
            this.HORARIOS.Image = ((System.Drawing.Image)(resources.GetObject("HORARIOS.Image")));
            this.HORARIOS.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.HORARIOS.Name = "HORARIOS";
            this.HORARIOS.ReadOnly = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(5, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 19);
            this.label14.TabIndex = 65;
            this.label14.Text = "HORARIOS";
            // 
            // LBPRUEBA
            // 
            this.LBPRUEBA.AutoSize = true;
            this.LBPRUEBA.BackColor = System.Drawing.Color.White;
            this.LBPRUEBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPRUEBA.ForeColor = System.Drawing.Color.Gray;
            this.LBPRUEBA.Location = new System.Drawing.Point(155, 86);
            this.LBPRUEBA.Name = "LBPRUEBA";
            this.LBPRUEBA.Size = new System.Drawing.Size(0, 20);
            this.LBPRUEBA.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(5, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 19);
            this.label2.TabIndex = 70;
            this.label2.Text = "GRUPOS INSCRITOS";
            // 
            // GRIDgruposinscritos
            // 
            this.GRIDgruposinscritos.AllowUserToAddRows = false;
            this.GRIDgruposinscritos.AllowUserToDeleteRows = false;
            this.GRIDgruposinscritos.AllowUserToOrderColumns = true;
            this.GRIDgruposinscritos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GRIDgruposinscritos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GRIDgruposinscritos.BackgroundColor = System.Drawing.Color.White;
            this.GRIDgruposinscritos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GRIDgruposinscritos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GRIDgruposinscritos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GRIDgruposinscritos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRIDgruposinscritos.ColumnHeadersVisible = false;
            this.GRIDgruposinscritos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DELETE});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRIDgruposinscritos.DefaultCellStyle = dataGridViewCellStyle4;
            this.GRIDgruposinscritos.Location = new System.Drawing.Point(9, 444);
            this.GRIDgruposinscritos.Name = "GRIDgruposinscritos";
            this.GRIDgruposinscritos.ReadOnly = true;
            this.GRIDgruposinscritos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GRIDgruposinscritos.RowHeadersVisible = false;
            this.GRIDgruposinscritos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GRIDgruposinscritos.Size = new System.Drawing.Size(1045, 256);
            this.GRIDgruposinscritos.TabIndex = 71;
            this.GRIDgruposinscritos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRIDgruposinscritos_CellContentClick);
            // 
            // DELETE
            // 
            this.DELETE.HeaderText = "DELETE";
            this.DELETE.Image = ((System.Drawing.Image)(resources.GetObject("DELETE.Image")));
            this.DELETE.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.DELETE.Name = "DELETE";
            this.DELETE.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(12, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 72;
            this.label6.Text = "ELIMINAR ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(387, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 19);
            this.label7.TabIndex = 73;
            this.label7.Text = "NOMBRE DEL GRUPO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(677, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 19);
            this.label9.TabIndex = 75;
            this.label9.Text = "MATERIA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(906, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 76;
            this.label8.Text = "MAESTRO";
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.Image = ((System.Drawing.Image)(resources.GetObject("BTNSALIR.Image")));
            this.BTNSALIR.Location = new System.Drawing.Point(1028, 1);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(34, 34);
            this.BTNSALIR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTNSALIR.TabIndex = 70;
            this.BTNSALIR.TabStop = false;
            this.BTNSALIR.Click += new System.EventHandler(this.BTNSALIR_Click);
            // 
            // MOVERFORM
            // 
            this.MOVERFORM.Fixed = true;
            this.MOVERFORM.Horizontal = true;
            this.MOVERFORM.TargetControl = this.PanelArriba;
            this.MOVERFORM.Vertical = true;
            // 
            // APARECER
            // 
            this.APARECER.Delay = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(198, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 19);
            this.label11.TabIndex = 77;
            this.label11.Text = "CODE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(198, 421);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 19);
            this.label13.TabIndex = 78;
            this.label13.Text = "CODE";
            // 
            // Inscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 761);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GRIDgruposinscritos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBPRUEBA);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.GRIDGrupos);
            this.Controls.Add(this.BTNTERMINAR);
            this.Controls.Add(this.BTNACTUALIZARGIRD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBMATERIAS);
            this.Controls.Add(this.label1);
            this.Name = "Inscripcion";
            this.Text = "DIAS";
            this.Load += new System.EventHandler(this.Inscripcion_Load);
            this.Controls.SetChildIndex(this.PanelArriba, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.CBMATERIAS, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.BTNACTUALIZARGIRD, 0);
            this.Controls.SetChildIndex(this.BTNTERMINAR, 0);
            this.Controls.SetChildIndex(this.GRIDGrupos, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.LBPRUEBA, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.GRIDgruposinscritos, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.PanelArriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GRIDGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRIDgruposinscritos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTNSALIR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBMATERIAS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton BTNACTUALIZARGIRD;
        private Bunifu.Framework.UI.BunifuFlatButton BTNTERMINAR;
        private System.Windows.Forms.DataGridView GRIDGrupos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LBPRUEBA;
        private System.Windows.Forms.DataGridViewImageColumn HORARIOS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GRIDgruposinscritos;
        private System.Windows.Forms.DataGridViewImageColumn DELETE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox BTNSALIR;
        private Bunifu.Framework.UI.BunifuDragControl MOVERFORM;
        private Bunifu.Framework.UI.BunifuFormFadeTransition APARECER;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
    }
}