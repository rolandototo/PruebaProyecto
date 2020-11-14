namespace CAPAPRESENTACION
{
    partial class FormBasePrin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBasePrin));
            this.PanelDerecha = new System.Windows.Forms.Panel();
            this.PanelArriba = new System.Windows.Forms.Panel();
            this.PanelFill = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelDerecha
            // 
            this.PanelDerecha.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelDerecha.Location = new System.Drawing.Point(0, 0);
            this.PanelDerecha.Name = "PanelDerecha";
            this.PanelDerecha.Size = new System.Drawing.Size(300, 800);
            this.PanelDerecha.TabIndex = 5;
            // 
            // PanelArriba
            // 
            this.PanelArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelArriba.Location = new System.Drawing.Point(300, 0);
            this.PanelArriba.Name = "PanelArriba";
            this.PanelArriba.Size = new System.Drawing.Size(1000, 100);
            this.PanelArriba.TabIndex = 6;
            // 
            // PanelFill
            // 
            this.PanelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFill.Location = new System.Drawing.Point(300, 100);
            this.PanelFill.Name = "PanelFill";
            this.PanelFill.Size = new System.Drawing.Size(1000, 700);
            this.PanelFill.TabIndex = 7;
            // 
            // FormBasePrin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.PanelFill);
            this.Controls.Add(this.PanelArriba);
            this.Controls.Add(this.PanelDerecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBasePrin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBasePrin";
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Panel PanelFill;
        protected System.Windows.Forms.Panel PanelArriba;
        protected System.Windows.Forms.Panel PanelDerecha;
    }
}