namespace Uma
{
    partial class Grupos
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
            this.label2 = new System.Windows.Forms.Label();
            this.DTGVgrupos = new System.Windows.Forms.DataGridView();
            this.DTGVhorarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVgrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVhorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(392, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mis Gruposl!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(407, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Horarios!";
            // 
            // DTGVgrupos
            // 
            this.DTGVgrupos.AllowUserToAddRows = false;
            this.DTGVgrupos.AllowUserToDeleteRows = false;
            this.DTGVgrupos.AllowUserToResizeColumns = false;
            this.DTGVgrupos.AllowUserToResizeRows = false;
            this.DTGVgrupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTGVgrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVgrupos.Location = new System.Drawing.Point(66, 83);
            this.DTGVgrupos.Name = "DTGVgrupos";
            this.DTGVgrupos.ReadOnly = true;
            this.DTGVgrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.DTGVgrupos.Size = new System.Drawing.Size(802, 196);
            this.DTGVgrupos.TabIndex = 14;
            // 
            // DTGVhorarios
            // 
            this.DTGVhorarios.AllowUserToAddRows = false;
            this.DTGVhorarios.AllowUserToDeleteRows = false;
            this.DTGVhorarios.AllowUserToResizeColumns = false;
            this.DTGVhorarios.AllowUserToResizeRows = false;
            this.DTGVhorarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTGVhorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVhorarios.Location = new System.Drawing.Point(66, 335);
            this.DTGVhorarios.Name = "DTGVhorarios";
            this.DTGVhorarios.ReadOnly = true;
            this.DTGVhorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.DTGVhorarios.Size = new System.Drawing.Size(802, 223);
            this.DTGVhorarios.TabIndex = 15;
            // 
            // Grupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 580);
            this.Controls.Add(this.DTGVhorarios);
            this.Controls.Add(this.DTGVgrupos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Grupos";
            this.Text = "Grupos";
            ((System.ComponentModel.ISupportInitialize)(this.DTGVgrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVhorarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DTGVgrupos;
        private System.Windows.Forms.DataGridView DTGVhorarios;
    }
}