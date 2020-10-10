namespace Uma
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGrupos = new System.Windows.Forms.Button();
            this.btnCrearGrupo = new System.Windows.Forms.Button();
            this.btnEliminarGrupo = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGrupos
            // 
            this.btnGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrupos.Location = new System.Drawing.Point(318, 165);
            this.btnGrupos.Name = "btnGrupos";
            this.btnGrupos.Size = new System.Drawing.Size(165, 36);
            this.btnGrupos.TabIndex = 0;
            this.btnGrupos.Text = "Mostrar grupos";
            this.btnGrupos.UseVisualStyleBackColor = true;
            // 
            // btnCrearGrupo
            // 
            this.btnCrearGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearGrupo.Location = new System.Drawing.Point(318, 249);
            this.btnCrearGrupo.Name = "btnCrearGrupo";
            this.btnCrearGrupo.Size = new System.Drawing.Size(165, 36);
            this.btnCrearGrupo.TabIndex = 1;
            this.btnCrearGrupo.Text = "Crear grupo";
            this.btnCrearGrupo.UseVisualStyleBackColor = true;
            // 
            // btnEliminarGrupo
            // 
            this.btnEliminarGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarGrupo.Location = new System.Drawing.Point(318, 333);
            this.btnEliminarGrupo.Name = "btnEliminarGrupo";
            this.btnEliminarGrupo.Size = new System.Drawing.Size(165, 36);
            this.btnEliminarGrupo.TabIndex = 2;
            this.btnEliminarGrupo.Text = "Eliminar grupo";
            this.btnEliminarGrupo.UseVisualStyleBackColor = true;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.Location = new System.Drawing.Point(318, 81);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(165, 36);
            this.btnPerfil.TabIndex = 3;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.btnEliminarGrupo);
            this.Controls.Add(this.btnCrearGrupo);
            this.Controls.Add(this.btnGrupos);
            this.Name = "Form1";
            this.Text = "Maestro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGrupos;
        private System.Windows.Forms.Button btnCrearGrupo;
        private System.Windows.Forms.Button btnEliminarGrupo;
        private System.Windows.Forms.Button btnPerfil;
    }
}

