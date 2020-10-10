namespace Uma
{
    partial class FormGrupo
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbGrupos = new System.Windows.Forms.ComboBox();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.btnDetalleAlumno = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grupos:";
            // 
            // cbGrupos
            // 
            this.cbGrupos.FormattingEnabled = true;
            this.cbGrupos.Location = new System.Drawing.Point(145, 28);
            this.cbGrupos.Name = "cbGrupos";
            this.cbGrupos.Size = new System.Drawing.Size(164, 24);
            this.cbGrupos.TabIndex = 1;
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(33, 91);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.RowHeadersWidth = 51;
            this.dgvAlumnos.RowTemplate.Height = 24;
            this.dgvAlumnos.Size = new System.Drawing.Size(584, 327);
            this.dgvAlumnos.TabIndex = 2;
            // 
            // btnDetalleAlumno
            // 
            this.btnDetalleAlumno.Location = new System.Drawing.Point(646, 124);
            this.btnDetalleAlumno.Name = "btnDetalleAlumno";
            this.btnDetalleAlumno.Size = new System.Drawing.Size(124, 43);
            this.btnDetalleAlumno.TabIndex = 3;
            this.btnDetalleAlumno.Text = "Detalle Alumno";
            this.btnDetalleAlumno.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(646, 204);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(124, 43);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(503, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Horario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Materia";
            // 
            // FormGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnDetalleAlumno);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.cbGrupos);
            this.Controls.Add(this.label1);
            this.Name = "FormGrupo";
            this.Text = "Grupo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGrupos;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Button btnDetalleAlumno;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}