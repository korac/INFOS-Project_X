namespace INFOS_Project_X
{
    partial class UvozForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UvozForm));
            this.dgvUvoz = new System.Windows.Forms.DataGridView();
            this.btnPohrani = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUvoz)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUvoz
            // 
            this.dgvUvoz.AllowUserToResizeColumns = false;
            this.dgvUvoz.AllowUserToResizeRows = false;
            this.dgvUvoz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUvoz.Location = new System.Drawing.Point(12, 71);
            this.dgvUvoz.MultiSelect = false;
            this.dgvUvoz.Name = "dgvUvoz";
            this.dgvUvoz.ReadOnly = true;
            this.dgvUvoz.RowHeadersVisible = false;
            this.dgvUvoz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUvoz.Size = new System.Drawing.Size(664, 266);
            this.dgvUvoz.TabIndex = 1;
            // 
            // btnPohrani
            // 
            this.btnPohrani.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPohrani.FlatAppearance.BorderSize = 0;
            this.btnPohrani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPohrani.ForeColor = System.Drawing.Color.White;
            this.btnPohrani.Location = new System.Drawing.Point(12, 12);
            this.btnPohrani.Name = "btnPohrani";
            this.btnPohrani.Size = new System.Drawing.Size(151, 46);
            this.btnPohrani.TabIndex = 2;
            this.btnPohrani.Text = "POHRANI U BAZU";
            this.btnPohrani.UseVisualStyleBackColor = false;
            this.btnPohrani.Visible = false;
            this.btnPohrani.Click += new System.EventHandler(this.btnPohrani_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdustani.BackColor = System.Drawing.Color.IndianRed;
            this.btnOdustani.FlatAppearance.BorderSize = 0;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.ForeColor = System.Drawing.Color.White;
            this.btnOdustani.Location = new System.Drawing.Point(525, 12);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(151, 46);
            this.btnOdustani.TabIndex = 3;
            this.btnOdustani.Text = "ODUSTANI";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Visible = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // UvozForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(688, 349);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPohrani);
            this.Controls.Add(this.dgvUvoz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UvozForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uvoz";
            this.Load += new System.EventHandler(this.UvozForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUvoz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvUvoz;
        private System.Windows.Forms.Button btnPohrani;
        private System.Windows.Forms.Button btnOdustani;
    }
}