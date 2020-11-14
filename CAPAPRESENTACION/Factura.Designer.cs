namespace CAPAPRESENTACION
{
    partial class Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.ReporteVista = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelFILL = new System.Windows.Forms.Panel();
            this.panelFILL.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReporteVista
            // 
            this.ReporteVista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReporteVista.Location = new System.Drawing.Point(0, 0);
            this.ReporteVista.Name = "ReporteVista";
            this.ReporteVista.ServerReport.BearerToken = null;
            this.ReporteVista.Size = new System.Drawing.Size(994, 719);
            this.ReporteVista.TabIndex = 1;
            // 
            // panelFILL
            // 
            this.panelFILL.Controls.Add(this.ReporteVista);
            this.panelFILL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFILL.Location = new System.Drawing.Point(0, 0);
            this.panelFILL.Name = "panelFILL";
            this.panelFILL.Size = new System.Drawing.Size(994, 719);
            this.panelFILL.TabIndex = 2;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(994, 719);
            this.Controls.Add(this.panelFILL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Factura";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Factura_FormClosing);
            this.Load += new System.EventHandler(this.Factura_Load);
            this.panelFILL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReporteVista;
        private System.Windows.Forms.Panel panelFILL;
    }
}