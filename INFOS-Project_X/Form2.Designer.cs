namespace INFOS_Project_X
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dgvPrikaz = new System.Windows.Forms.DataGridView();
            this.lblPrikaz = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.gboxStart = new System.Windows.Forms.GroupBox();
            this.gboxIzvozUvoz = new System.Windows.Forms.GroupBox();
            this.btnUveziXML = new System.Windows.Forms.Button();
            this.btnSpremiXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).BeginInit();
            this.gboxStart.SuspendLayout();
            this.gboxIzvozUvoz.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrikaz
            // 
            this.dgvPrikaz.AllowUserToResizeColumns = false;
            this.dgvPrikaz.AllowUserToResizeRows = false;
            this.dgvPrikaz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrikaz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikaz.Location = new System.Drawing.Point(13, 84);
            this.dgvPrikaz.MultiSelect = false;
            this.dgvPrikaz.Name = "dgvPrikaz";
            this.dgvPrikaz.ReadOnly = true;
            this.dgvPrikaz.RowHeadersVisible = false;
            this.dgvPrikaz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrikaz.Size = new System.Drawing.Size(796, 300);
            this.dgvPrikaz.TabIndex = 0;
            // 
            // lblPrikaz
            // 
            this.lblPrikaz.AutoSize = true;
            this.lblPrikaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrikaz.ForeColor = System.Drawing.Color.LightGray;
            this.lblPrikaz.Location = new System.Drawing.Point(12, 33);
            this.lblPrikaz.Name = "lblPrikaz";
            this.lblPrikaz.Size = new System.Drawing.Size(60, 24);
            this.lblPrikaz.TabIndex = 1;
            this.lblPrikaz.Text = "Prikaz";
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(12, 16);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(83, 38);
            this.btnDodaj.TabIndex = 9;
            this.btnDodaj.Text = "DODAJ";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUredi.FlatAppearance.BorderSize = 0;
            this.btnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUredi.ForeColor = System.Drawing.Color.White;
            this.btnUredi.Location = new System.Drawing.Point(101, 16);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(83, 38);
            this.btnUredi.TabIndex = 10;
            this.btnUredi.Text = "UREDI";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.BackColor = System.Drawing.Color.IndianRed;
            this.btnIzbrisi.FlatAppearance.BorderSize = 0;
            this.btnIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisi.ForeColor = System.Drawing.Color.White;
            this.btnIzbrisi.Location = new System.Drawing.Point(190, 16);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(83, 38);
            this.btnIzbrisi.TabIndex = 11;
            this.btnIzbrisi.Text = "IZBRIŠI";
            this.btnIzbrisi.UseVisualStyleBackColor = false;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdaberi.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnOdaberi.FlatAppearance.BorderSize = 0;
            this.btnOdaberi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdaberi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdaberi.ForeColor = System.Drawing.Color.White;
            this.btnOdaberi.Location = new System.Drawing.Point(564, 404);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(114, 45);
            this.btnOdaberi.TabIndex = 13;
            this.btnOdaberi.Text = "ODABERI";
            this.btnOdaberi.UseVisualStyleBackColor = false;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdustani.BackColor = System.Drawing.Color.IndianRed;
            this.btnOdustani.FlatAppearance.BorderSize = 0;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdustani.ForeColor = System.Drawing.Color.White;
            this.btnOdustani.Location = new System.Drawing.Point(684, 404);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(114, 45);
            this.btnOdustani.TabIndex = 14;
            this.btnOdustani.Text = "ODUSTANI";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // gboxStart
            // 
            this.gboxStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxStart.Controls.Add(this.btnUredi);
            this.gboxStart.Controls.Add(this.btnIzbrisi);
            this.gboxStart.Controls.Add(this.btnDodaj);
            this.gboxStart.ForeColor = System.Drawing.Color.LightGray;
            this.gboxStart.Location = new System.Drawing.Point(525, 12);
            this.gboxStart.Name = "gboxStart";
            this.gboxStart.Size = new System.Drawing.Size(284, 66);
            this.gboxStart.TabIndex = 16;
            this.gboxStart.TabStop = false;
            this.gboxStart.Text = "Kontrole";
            // 
            // gboxIzvozUvoz
            // 
            this.gboxIzvozUvoz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gboxIzvozUvoz.Controls.Add(this.btnUveziXML);
            this.gboxIzvozUvoz.Controls.Add(this.btnSpremiXML);
            this.gboxIzvozUvoz.ForeColor = System.Drawing.Color.LightGray;
            this.gboxIzvozUvoz.Location = new System.Drawing.Point(16, 390);
            this.gboxIzvozUvoz.Name = "gboxIzvozUvoz";
            this.gboxIzvozUvoz.Size = new System.Drawing.Size(273, 75);
            this.gboxIzvozUvoz.TabIndex = 19;
            this.gboxIzvozUvoz.TabStop = false;
            this.gboxIzvozUvoz.Text = "Izvoz/Uvoz";
            // 
            // btnUveziXML
            // 
            this.btnUveziXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUveziXML.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUveziXML.FlatAppearance.BorderSize = 0;
            this.btnUveziXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUveziXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUveziXML.ForeColor = System.Drawing.Color.White;
            this.btnUveziXML.Location = new System.Drawing.Point(139, 19);
            this.btnUveziXML.Name = "btnUveziXML";
            this.btnUveziXML.Size = new System.Drawing.Size(114, 45);
            this.btnUveziXML.TabIndex = 17;
            this.btnUveziXML.Text = "UVEZI DATOTEKU (XML)";
            this.btnUveziXML.UseVisualStyleBackColor = false;
            this.btnUveziXML.Click += new System.EventHandler(this.btnUvezi_Click);
            // 
            // btnSpremiXML
            // 
            this.btnSpremiXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSpremiXML.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSpremiXML.FlatAppearance.BorderSize = 0;
            this.btnSpremiXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremiXML.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremiXML.ForeColor = System.Drawing.Color.White;
            this.btnSpremiXML.Location = new System.Drawing.Point(19, 19);
            this.btnSpremiXML.Name = "btnSpremiXML";
            this.btnSpremiXML.Size = new System.Drawing.Size(114, 45);
            this.btnSpremiXML.TabIndex = 15;
            this.btnSpremiXML.Text = "IZVEZI DATOTEKU (XML)";
            this.btnSpremiXML.UseVisualStyleBackColor = false;
            this.btnSpremiXML.Click += new System.EventHandler(this.btnSpremiXML_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(821, 471);
            this.ControlBox = false;
            this.Controls.Add(this.gboxIzvozUvoz);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.lblPrikaz);
            this.Controls.Add(this.dgvPrikaz);
            this.Controls.Add(this.gboxStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikaz)).EndInit();
            this.gboxStart.ResumeLayout(false);
            this.gboxIzvozUvoz.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrikaz;
        private System.Windows.Forms.Label lblPrikaz;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.GroupBox gboxStart;
        private System.Windows.Forms.GroupBox gboxIzvozUvoz;
        private System.Windows.Forms.Button btnUveziXML;
        private System.Windows.Forms.Button btnSpremiXML;
    }
}