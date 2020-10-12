namespace Uma
{
    partial class Inner_Group_Notas_Alum
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
            this.DTGVhorarios = new System.Windows.Forms.DataGridView();
            this.DTGVgrupos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVhorarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVgrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGVhorarios
            // 
            this.DTGVhorarios.AllowUserToAddRows = false;
            this.DTGVhorarios.AllowUserToDeleteRows = false;
            this.DTGVhorarios.AllowUserToResizeColumns = false;
            this.DTGVhorarios.AllowUserToResizeRows = false;
            this.DTGVhorarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTGVhorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVhorarios.Location = new System.Drawing.Point(64, 324);
            this.DTGVhorarios.Name = "DTGVhorarios";
            this.DTGVhorarios.ReadOnly = true;
            this.DTGVhorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.DTGVhorarios.Size = new System.Drawing.Size(802, 223);
            this.DTGVhorarios.TabIndex = 19;
            // 
            // DTGVgrupos
            // 
            this.DTGVgrupos.AllowUserToAddRows = false;
            this.DTGVgrupos.AllowUserToDeleteRows = false;
            this.DTGVgrupos.AllowUserToResizeColumns = false;
            this.DTGVgrupos.AllowUserToResizeRows = false;
            this.DTGVgrupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTGVgrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVgrupos.Location = new System.Drawing.Point(64, 72);
            this.DTGVgrupos.Name = "DTGVgrupos";
            this.DTGVgrupos.ReadOnly = true;
            this.DTGVgrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.DTGVgrupos.Size = new System.Drawing.Size(802, 196);
            this.DTGVgrupos.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(405, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Horarios!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(390, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mis Gruposl!";
            // 
            // Inner_Group_Notas_Alum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 576);
            this.Controls.Add(this.DTGVhorarios);
            this.Controls.Add(this.DTGVgrupos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Inner_Group_Notas_Alum";
            this.Text = "Inner_Group_Notas_Alum";
            ((System.ComponentModel.ISupportInitialize)(this.DTGVhorarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVgrupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGVhorarios;
        private System.Windows.Forms.DataGridView DTGVgrupos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}