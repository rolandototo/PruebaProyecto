namespace CAPAPRESENTACION
{
    partial class FormDefault
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
            this.lbHora = new System.Windows.Forms.Label();
            this.LBFecha = new System.Windows.Forms.Label();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PanelArriba
            // 
            this.PanelArriba.Size = new System.Drawing.Size(1066, 100);
            // 
            // lbHora
            // 
            this.lbHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbHora.BackColor = System.Drawing.Color.Transparent;
            this.lbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(145, 272);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(776, 43);
            this.lbHora.TabIndex = 1;
            this.lbHora.Text = "label1";
            this.lbHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBFecha
            // 
            this.LBFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBFecha.BackColor = System.Drawing.Color.Transparent;
            this.LBFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBFecha.Location = new System.Drawing.Point(145, 528);
            this.LBFecha.Name = "LBFecha";
            this.LBFecha.Size = new System.Drawing.Size(776, 44);
            this.LBFecha.TabIndex = 2;
            this.LBFecha.Text = "label2";
            this.LBFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // FormDefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 761);
            this.Controls.Add(this.LBFecha);
            this.Controls.Add(this.lbHora);
            this.Name = "FormDefault";
            this.Text = "FormDefault";
            this.Controls.SetChildIndex(this.PanelArriba, 0);
            this.Controls.SetChildIndex(this.lbHora, 0);
            this.Controls.SetChildIndex(this.LBFecha, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label LBFecha;
        private System.Windows.Forms.Timer HoraFecha;
    }
}