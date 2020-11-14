namespace CAPAPRESENTACION
{
    partial class FormInvocadoBase
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
            this.curva = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelArriba = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // curva
            // 
            this.curva.ElipseRadius = 7;
            this.curva.TargetControl = this;
            // 
            // PanelArriba
            // 
            this.PanelArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.PanelArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelArriba.Location = new System.Drawing.Point(0, 0);
            this.PanelArriba.Name = "PanelArriba";
            this.PanelArriba.Size = new System.Drawing.Size(982, 95);
            this.PanelArriba.TabIndex = 0;
            // 
            // FormInvocadoBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 672);
            this.Controls.Add(this.PanelArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInvocadoBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInvocadoBase";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse curva;
        protected System.Windows.Forms.Panel PanelArriba;
    }
}