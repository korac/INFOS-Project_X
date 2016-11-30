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
            this.btnUveziClanove = new System.Windows.Forms.Button();
            this.dgvUvoz = new System.Windows.Forms.DataGridView();
            this.btnPohrani = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnUveziDrustva = new System.Windows.Forms.Button();
            this.btnUveziMjesta = new System.Windows.Forms.Button();
            this.btnUveziDrzave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUvoz)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUveziClanove
            // 
            this.btnUveziClanove.Location = new System.Drawing.Point(44, 99);
            this.btnUveziClanove.Name = "btnUveziClanove";
            this.btnUveziClanove.Size = new System.Drawing.Size(100, 159);
            this.btnUveziClanove.TabIndex = 0;
            this.btnUveziClanove.Text = "Uvezi članove";
            this.btnUveziClanove.UseVisualStyleBackColor = true;
            this.btnUveziClanove.Click += new System.EventHandler(this.btnUveziClanove_Click);
            // 
            // dgvUvoz
            // 
            this.dgvUvoz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUvoz.Location = new System.Drawing.Point(12, 71);
            this.dgvUvoz.Name = "dgvUvoz";
            this.dgvUvoz.Size = new System.Drawing.Size(664, 266);
            this.dgvUvoz.TabIndex = 1;
            this.dgvUvoz.Visible = false;
            // 
            // btnPohrani
            // 
            this.btnPohrani.Location = new System.Drawing.Point(12, 12);
            this.btnPohrani.Name = "btnPohrani";
            this.btnPohrani.Size = new System.Drawing.Size(194, 46);
            this.btnPohrani.TabIndex = 2;
            this.btnPohrani.Text = "Pohrani u bazu";
            this.btnPohrani.UseVisualStyleBackColor = true;
            this.btnPohrani.Visible = false;
            this.btnPohrani.Click += new System.EventHandler(this.btnPohrani_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(482, 12);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(194, 46);
            this.btnOdustani.TabIndex = 3;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Visible = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnUveziDrustva
            // 
            this.btnUveziDrustva.Location = new System.Drawing.Point(212, 99);
            this.btnUveziDrustva.Name = "btnUveziDrustva";
            this.btnUveziDrustva.Size = new System.Drawing.Size(100, 159);
            this.btnUveziDrustva.TabIndex = 4;
            this.btnUveziDrustva.Text = "Uvezi društva";
            this.btnUveziDrustva.UseVisualStyleBackColor = true;
            this.btnUveziDrustva.Click += new System.EventHandler(this.btnUveziDrustva_Click);
            // 
            // btnUveziMjesta
            // 
            this.btnUveziMjesta.Location = new System.Drawing.Point(379, 99);
            this.btnUveziMjesta.Name = "btnUveziMjesta";
            this.btnUveziMjesta.Size = new System.Drawing.Size(100, 159);
            this.btnUveziMjesta.TabIndex = 5;
            this.btnUveziMjesta.Text = "Uvezi mjesta";
            this.btnUveziMjesta.UseVisualStyleBackColor = true;
            this.btnUveziMjesta.Click += new System.EventHandler(this.btnUveziMjesta_Click);
            // 
            // btnUveziDrzave
            // 
            this.btnUveziDrzave.Location = new System.Drawing.Point(538, 99);
            this.btnUveziDrzave.Name = "btnUveziDrzave";
            this.btnUveziDrzave.Size = new System.Drawing.Size(100, 159);
            this.btnUveziDrzave.TabIndex = 6;
            this.btnUveziDrzave.Text = "Uvezi države";
            this.btnUveziDrzave.UseVisualStyleBackColor = true;
            this.btnUveziDrzave.Click += new System.EventHandler(this.btnUveziDrzave_Click);
            // 
            // UvozForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 349);
            this.Controls.Add(this.btnUveziDrzave);
            this.Controls.Add(this.btnUveziMjesta);
            this.Controls.Add(this.btnUveziDrustva);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPohrani);
            this.Controls.Add(this.btnUveziClanove);
            this.Controls.Add(this.dgvUvoz);
            this.Name = "UvozForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uvoz";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUvoz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUveziClanove;
        private System.Windows.Forms.DataGridView dgvUvoz;
        private System.Windows.Forms.Button btnPohrani;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnUveziDrustva;
        private System.Windows.Forms.Button btnUveziMjesta;
        private System.Windows.Forms.Button btnUveziDrzave;
    }
}