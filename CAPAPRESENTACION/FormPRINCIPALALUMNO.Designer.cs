namespace CAPAPRESENTACION
{
    partial class FormPRINCIPALALUMNO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPRINCIPALALUMNO));
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BTNRETIROS = new FontAwesome.Sharp.IconButton();
            this.btncerrarsesion = new FontAwesome.Sharp.IconButton();
            this.BTNMATERIAS = new FontAwesome.Sharp.IconButton();
            this.btnInscripcion = new FontAwesome.Sharp.IconButton();
            this.BTNPAGOS = new FontAwesome.Sharp.IconButton();
            this.BTNMISGRUPOS = new FontAwesome.Sharp.IconButton();
            this.BTNNOTAS = new FontAwesome.Sharp.IconButton();
            this.BTNPERFIL = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.LOGOpicturebox = new System.Windows.Forms.PictureBox();
            this.LineaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.lbtitulo = new System.Windows.Forms.Label();
            this.PanelChart = new System.Windows.Forms.Panel();
            this.READONDEARSIDEBAR = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.REDONDIARINVOCARFORMS = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.IconBoxCurrent = new FontAwesome.Sharp.IconPictureBox();
            this.PanelFill.SuspendLayout();
            this.PanelArriba.SuspendLayout();
            this.PanelDerecha.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LOGOpicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconBoxCurrent)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelFill
            // 
            this.PanelFill.Controls.Add(this.PanelChart);
            this.PanelFill.Location = new System.Drawing.Point(300, 79);
            this.PanelFill.Size = new System.Drawing.Size(1084, 782);
            // 
            // PanelArriba
            // 
            this.PanelArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.PanelArriba.Controls.Add(this.IconBoxCurrent);
            this.PanelArriba.Controls.Add(this.lbtitulo);
            this.PanelArriba.Size = new System.Drawing.Size(1084, 79);
            // 
            // PanelDerecha
            // 
            this.PanelDerecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.PanelDerecha.Controls.Add(this.Sidebar);
            this.PanelDerecha.Size = new System.Drawing.Size(300, 861);
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.BTNRETIROS);
            this.Sidebar.Controls.Add(this.btncerrarsesion);
            this.Sidebar.Controls.Add(this.BTNMATERIAS);
            this.Sidebar.Controls.Add(this.btnInscripcion);
            this.Sidebar.Controls.Add(this.BTNPAGOS);
            this.Sidebar.Controls.Add(this.BTNMISGRUPOS);
            this.Sidebar.Controls.Add(this.BTNNOTAS);
            this.Sidebar.Controls.Add(this.BTNPERFIL);
            this.Sidebar.Controls.Add(this.label2);
            this.Sidebar.Controls.Add(this.LOGOpicturebox);
            this.Sidebar.Controls.Add(this.LineaSidebar);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Sidebar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Sidebar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Sidebar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.Sidebar.Location = new System.Drawing.Point(15, 38);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(270, 811);
            this.Sidebar.TabIndex = 1;
            // 
            // BTNRETIROS
            // 
            this.BTNRETIROS.FlatAppearance.BorderSize = 0;
            this.BTNRETIROS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNRETIROS.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.BTNRETIROS.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTNRETIROS.IconChar = FontAwesome.Sharp.IconChar.CalendarTimes;
            this.BTNRETIROS.IconColor = System.Drawing.Color.Gainsboro;
            this.BTNRETIROS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTNRETIROS.IconSize = 36;
            this.BTNRETIROS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNRETIROS.Location = new System.Drawing.Point(-2, 580);
            this.BTNRETIROS.Name = "BTNRETIROS";
            this.BTNRETIROS.Size = new System.Drawing.Size(270, 61);
            this.BTNRETIROS.TabIndex = 20;
            this.BTNRETIROS.Text = "RETIROS";
            this.BTNRETIROS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNRETIROS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNRETIROS.UseVisualStyleBackColor = true;
            this.BTNRETIROS.Click += new System.EventHandler(this.BTNRETIROS_Click);
            // 
            // btncerrarsesion
            // 
            this.btncerrarsesion.FlatAppearance.BorderSize = 0;
            this.btncerrarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrarsesion.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btncerrarsesion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btncerrarsesion.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btncerrarsesion.IconColor = System.Drawing.Color.Gainsboro;
            this.btncerrarsesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncerrarsesion.IconSize = 36;
            this.btncerrarsesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncerrarsesion.Location = new System.Drawing.Point(0, 647);
            this.btncerrarsesion.Name = "btncerrarsesion";
            this.btncerrarsesion.Size = new System.Drawing.Size(270, 61);
            this.btncerrarsesion.TabIndex = 19;
            this.btncerrarsesion.Text = "CERRAR SESION";
            this.btncerrarsesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncerrarsesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncerrarsesion.UseVisualStyleBackColor = true;
            this.btncerrarsesion.Click += new System.EventHandler(this.btncerrarsesion_Click_1);
            // 
            // BTNMATERIAS
            // 
            this.BTNMATERIAS.FlatAppearance.BorderSize = 0;
            this.BTNMATERIAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNMATERIAS.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.BTNMATERIAS.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTNMATERIAS.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.BTNMATERIAS.IconColor = System.Drawing.Color.Gainsboro;
            this.BTNMATERIAS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTNMATERIAS.IconSize = 36;
            this.BTNMATERIAS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNMATERIAS.Location = new System.Drawing.Point(0, 513);
            this.BTNMATERIAS.Name = "BTNMATERIAS";
            this.BTNMATERIAS.Size = new System.Drawing.Size(270, 61);
            this.BTNMATERIAS.TabIndex = 17;
            this.BTNMATERIAS.Text = "MATERIAS";
            this.BTNMATERIAS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNMATERIAS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNMATERIAS.UseVisualStyleBackColor = true;
            this.BTNMATERIAS.Click += new System.EventHandler(this.BTNMATERIAS_Click_1);
            // 
            // btnInscripcion
            // 
            this.btnInscripcion.FlatAppearance.BorderSize = 0;
            this.btnInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscripcion.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btnInscripcion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInscripcion.IconChar = FontAwesome.Sharp.IconChar.PrescriptionBottle;
            this.btnInscripcion.IconColor = System.Drawing.Color.Gainsboro;
            this.btnInscripcion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInscripcion.IconSize = 36;
            this.btnInscripcion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInscripcion.Location = new System.Drawing.Point(0, 446);
            this.btnInscripcion.Name = "btnInscripcion";
            this.btnInscripcion.Size = new System.Drawing.Size(268, 61);
            this.btnInscripcion.TabIndex = 17;
            this.btnInscripcion.Text = "INSCRIPCION";
            this.btnInscripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInscripcion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInscripcion.UseVisualStyleBackColor = true;
            this.btnInscripcion.Click += new System.EventHandler(this.btnInscripcion_Click_1);
            // 
            // BTNPAGOS
            // 
            this.BTNPAGOS.FlatAppearance.BorderSize = 0;
            this.BTNPAGOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNPAGOS.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.BTNPAGOS.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTNPAGOS.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            this.BTNPAGOS.IconColor = System.Drawing.Color.Gainsboro;
            this.BTNPAGOS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTNPAGOS.IconSize = 36;
            this.BTNPAGOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNPAGOS.Location = new System.Drawing.Point(0, 379);
            this.BTNPAGOS.Name = "BTNPAGOS";
            this.BTNPAGOS.Size = new System.Drawing.Size(270, 61);
            this.BTNPAGOS.TabIndex = 17;
            this.BTNPAGOS.Text = "PAGOS";
            this.BTNPAGOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNPAGOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNPAGOS.UseVisualStyleBackColor = true;
            this.BTNPAGOS.Click += new System.EventHandler(this.BTNPAGOS_Click_1);
            // 
            // BTNMISGRUPOS
            // 
            this.BTNMISGRUPOS.FlatAppearance.BorderSize = 0;
            this.BTNMISGRUPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNMISGRUPOS.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.BTNMISGRUPOS.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTNMISGRUPOS.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.BTNMISGRUPOS.IconColor = System.Drawing.Color.Gainsboro;
            this.BTNMISGRUPOS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTNMISGRUPOS.IconSize = 36;
            this.BTNMISGRUPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNMISGRUPOS.Location = new System.Drawing.Point(-1, 312);
            this.BTNMISGRUPOS.Name = "BTNMISGRUPOS";
            this.BTNMISGRUPOS.Size = new System.Drawing.Size(270, 61);
            this.BTNMISGRUPOS.TabIndex = 18;
            this.BTNMISGRUPOS.Text = "MIS GRUPOS";
            this.BTNMISGRUPOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNMISGRUPOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNMISGRUPOS.UseVisualStyleBackColor = true;
            this.BTNMISGRUPOS.Click += new System.EventHandler(this.BTNMISGRUPOS_Click_1);
            // 
            // BTNNOTAS
            // 
            this.BTNNOTAS.FlatAppearance.BorderSize = 0;
            this.BTNNOTAS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNNOTAS.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNNOTAS.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTNNOTAS.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            this.BTNNOTAS.IconColor = System.Drawing.Color.Gainsboro;
            this.BTNNOTAS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTNNOTAS.IconSize = 36;
            this.BTNNOTAS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNNOTAS.Location = new System.Drawing.Point(-1, 245);
            this.BTNNOTAS.Name = "BTNNOTAS";
            this.BTNNOTAS.Size = new System.Drawing.Size(270, 61);
            this.BTNNOTAS.TabIndex = 17;
            this.BTNNOTAS.Text = "MIS NOTAS";
            this.BTNNOTAS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNNOTAS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNNOTAS.UseVisualStyleBackColor = true;
            this.BTNNOTAS.Click += new System.EventHandler(this.BTNNOTAS_Click_1);
            // 
            // BTNPERFIL
            // 
            this.BTNPERFIL.FlatAppearance.BorderSize = 0;
            this.BTNPERFIL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNPERFIL.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPERFIL.ForeColor = System.Drawing.Color.Gainsboro;
            this.BTNPERFIL.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            this.BTNPERFIL.IconColor = System.Drawing.Color.Gainsboro;
            this.BTNPERFIL.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTNPERFIL.IconSize = 36;
            this.BTNPERFIL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNPERFIL.Location = new System.Drawing.Point(0, 178);
            this.BTNPERFIL.Name = "BTNPERFIL";
            this.BTNPERFIL.Size = new System.Drawing.Size(270, 61);
            this.BTNPERFIL.TabIndex = 16;
            this.BTNPERFIL.Text = "PERFIL";
            this.BTNPERFIL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNPERFIL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNPERFIL.UseVisualStyleBackColor = true;
            this.BTNPERFIL.Click += new System.EventHandler(this.BTNPERFIL_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 16.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(123, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "UMA";
            // 
            // LOGOpicturebox
            // 
            this.LOGOpicturebox.BackColor = System.Drawing.Color.Transparent;
            this.LOGOpicturebox.Image = ((System.Drawing.Image)(resources.GetObject("LOGOpicturebox.Image")));
            this.LOGOpicturebox.Location = new System.Drawing.Point(27, 50);
            this.LOGOpicturebox.Name = "LOGOpicturebox";
            this.LOGOpicturebox.Size = new System.Drawing.Size(53, 51);
            this.LOGOpicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LOGOpicturebox.TabIndex = 6;
            this.LOGOpicturebox.TabStop = false;
            this.LOGOpicturebox.Click += new System.EventHandler(this.LOGOpicturebox_Click);
            // 
            // LineaSidebar
            // 
            this.LineaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.LineaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LineaSidebar.LineThickness = 1;
            this.LineaSidebar.Location = new System.Drawing.Point(-1, 130);
            this.LineaSidebar.Name = "LineaSidebar";
            this.LineaSidebar.Size = new System.Drawing.Size(269, 1);
            this.LineaSidebar.TabIndex = 7;
            this.LineaSidebar.Transparency = 255;
            this.LineaSidebar.Vertical = false;
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lbtitulo.Location = new System.Drawing.Point(63, 34);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(77, 21);
            this.lbtitulo.TabIndex = 3;
            this.lbtitulo.Text = "SISTEMA";
            // 
            // PanelChart
            // 
            this.PanelChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelChart.BackColor = System.Drawing.Color.White;
            this.PanelChart.Location = new System.Drawing.Point(6, 9);
            this.PanelChart.Name = "PanelChart";
            this.PanelChart.Size = new System.Drawing.Size(1066, 761);
            this.PanelChart.TabIndex = 1;
            // 
            // READONDEARSIDEBAR
            // 
            this.READONDEARSIDEBAR.ElipseRadius = 7;
            this.READONDEARSIDEBAR.TargetControl = this.Sidebar;
            // 
            // REDONDIARINVOCARFORMS
            // 
            this.REDONDIARINVOCARFORMS.ElipseRadius = 7;
            this.REDONDIARINVOCARFORMS.TargetControl = this.PanelChart;
            // 
            // IconBoxCurrent
            // 
            this.IconBoxCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.IconBoxCurrent.ForeColor = System.Drawing.Color.DimGray;
            this.IconBoxCurrent.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconBoxCurrent.IconColor = System.Drawing.Color.DimGray;
            this.IconBoxCurrent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconBoxCurrent.Location = new System.Drawing.Point(28, 27);
            this.IconBoxCurrent.Name = "IconBoxCurrent";
            this.IconBoxCurrent.Size = new System.Drawing.Size(32, 32);
            this.IconBoxCurrent.TabIndex = 4;
            this.IconBoxCurrent.TabStop = false;
            // 
            // FormPRINCIPALALUMNO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.MinimumSize = new System.Drawing.Size(1400, 900);
            this.Name = "FormPRINCIPALALUMNO";
            this.Text = "FormPRINCIPALALUMNO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPRINCIPALALUMNO_FormClosing);
            this.PanelFill.ResumeLayout(false);
            this.PanelArriba.ResumeLayout(false);
            this.PanelArriba.PerformLayout();
            this.PanelDerecha.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LOGOpicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconBoxCurrent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelChart;
        private System.Windows.Forms.Label lbtitulo;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private Bunifu.Framework.UI.BunifuSeparator LineaSidebar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox LOGOpicturebox;
        private Bunifu.Framework.UI.BunifuElipse READONDEARSIDEBAR;
        private Bunifu.Framework.UI.BunifuElipse REDONDIARINVOCARFORMS;
        private FontAwesome.Sharp.IconButton BTNPERFIL;
        private FontAwesome.Sharp.IconButton btncerrarsesion;
        private FontAwesome.Sharp.IconButton BTNMATERIAS;
        private FontAwesome.Sharp.IconButton btnInscripcion;
        private FontAwesome.Sharp.IconButton BTNPAGOS;
        private FontAwesome.Sharp.IconButton BTNMISGRUPOS;
        private FontAwesome.Sharp.IconButton BTNNOTAS;
        private FontAwesome.Sharp.IconButton BTNRETIROS;
        private FontAwesome.Sharp.IconPictureBox IconBoxCurrent;
    }
}