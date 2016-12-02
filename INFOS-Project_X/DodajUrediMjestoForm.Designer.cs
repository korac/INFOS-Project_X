namespace INFOS_Project_X
{
    partial class DodajUrediMjestoForm
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
            this.lblUrediIme = new System.Windows.Forms.Label();
            this.tboxIme = new System.Windows.Forms.TextBox();
            this.lblUrediDrzava = new System.Windows.Forms.Label();
            this.cboxDrzava = new System.Windows.Forms.ComboBox();
            this.btnOdaberiDrzavu = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPrihvati = new System.Windows.Forms.Button();
            this.errProviderIme = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMjestoID = new System.Windows.Forms.Label();
            this.tboxMjestoID = new System.Windows.Forms.TextBox();
            this.errProviderID = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProviderIme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderID)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrediIme
            // 
            this.lblUrediIme.AutoSize = true;
            this.lblUrediIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrediIme.Location = new System.Drawing.Point(66, 77);
            this.lblUrediIme.Name = "lblUrediIme";
            this.lblUrediIme.Size = new System.Drawing.Size(34, 17);
            this.lblUrediIme.TabIndex = 25;
            this.lblUrediIme.Text = "Ime:";
            // 
            // tboxIme
            // 
            this.tboxIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxIme.Location = new System.Drawing.Point(115, 74);
            this.tboxIme.Name = "tboxIme";
            this.tboxIme.Size = new System.Drawing.Size(206, 23);
            this.tboxIme.TabIndex = 24;
            this.tboxIme.Validating += new System.ComponentModel.CancelEventHandler(this.tboxIme_Validating);
            // 
            // lblUrediDrzava
            // 
            this.lblUrediDrzava.AutoSize = true;
            this.lblUrediDrzava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrediDrzava.Location = new System.Drawing.Point(43, 118);
            this.lblUrediDrzava.Name = "lblUrediDrzava";
            this.lblUrediDrzava.Size = new System.Drawing.Size(57, 17);
            this.lblUrediDrzava.TabIndex = 28;
            this.lblUrediDrzava.Text = "Država:";
            // 
            // cboxDrzava
            // 
            this.cboxDrzava.FormattingEnabled = true;
            this.cboxDrzava.Location = new System.Drawing.Point(115, 118);
            this.cboxDrzava.Name = "cboxDrzava";
            this.cboxDrzava.Size = new System.Drawing.Size(170, 21);
            this.cboxDrzava.TabIndex = 35;
            // 
            // btnOdaberiDrzavu
            // 
            this.btnOdaberiDrzavu.Location = new System.Drawing.Point(291, 117);
            this.btnOdaberiDrzavu.Name = "btnOdaberiDrzavu";
            this.btnOdaberiDrzavu.Size = new System.Drawing.Size(30, 21);
            this.btnOdaberiDrzavu.TabIndex = 36;
            this.btnOdaberiDrzavu.Text = "...";
            this.btnOdaberiDrzavu.UseVisualStyleBackColor = true;
            this.btnOdaberiDrzavu.Click += new System.EventHandler(this.btnOdaberiDrzavu_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(220, 174);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(101, 30);
            this.btnOdustani.TabIndex = 38;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnPrihvati
            // 
            this.btnPrihvati.Location = new System.Drawing.Point(102, 174);
            this.btnPrihvati.Name = "btnPrihvati";
            this.btnPrihvati.Size = new System.Drawing.Size(101, 30);
            this.btnPrihvati.TabIndex = 37;
            this.btnPrihvati.Text = "Prihvati";
            this.btnPrihvati.UseVisualStyleBackColor = true;
            this.btnPrihvati.Click += new System.EventHandler(this.btnPrihvati_Click);
            // 
            // errProviderIme
            // 
            this.errProviderIme.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderIme.ContainerControl = this;
            // 
            // lblMjestoID
            // 
            this.lblMjestoID.AutoSize = true;
            this.lblMjestoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMjestoID.Location = new System.Drawing.Point(30, 34);
            this.lblMjestoID.Name = "lblMjestoID";
            this.lblMjestoID.Size = new System.Drawing.Size(70, 17);
            this.lblMjestoID.TabIndex = 40;
            this.lblMjestoID.Text = "Mjesto ID:";
            // 
            // tboxMjestoID
            // 
            this.tboxMjestoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxMjestoID.Location = new System.Drawing.Point(115, 31);
            this.tboxMjestoID.Name = "tboxMjestoID";
            this.tboxMjestoID.Size = new System.Drawing.Size(206, 23);
            this.tboxMjestoID.TabIndex = 39;
            this.tboxMjestoID.Validating += new System.ComponentModel.CancelEventHandler(this.tboxMjestoID_Validating);
            // 
            // errProviderID
            // 
            this.errProviderID.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderID.ContainerControl = this;
            // 
            // DodajUrediMjestoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 228);
            this.Controls.Add(this.lblMjestoID);
            this.Controls.Add(this.tboxMjestoID);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPrihvati);
            this.Controls.Add(this.btnOdaberiDrzavu);
            this.Controls.Add(this.cboxDrzava);
            this.Controls.Add(this.lblUrediDrzava);
            this.Controls.Add(this.lblUrediIme);
            this.Controls.Add(this.tboxIme);
            this.Name = "DodajUrediMjestoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DodajUrediMjestoForm";
            this.Load += new System.EventHandler(this.DodajUrediMjestoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProviderIme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUrediIme;
        private System.Windows.Forms.TextBox tboxIme;
        private System.Windows.Forms.Label lblUrediDrzava;
        private System.Windows.Forms.ComboBox cboxDrzava;
        private System.Windows.Forms.Button btnOdaberiDrzavu;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnPrihvati;
        private System.Windows.Forms.ErrorProvider errProviderIme;
        private System.Windows.Forms.Label lblMjestoID;
        private System.Windows.Forms.TextBox tboxMjestoID;
        private System.Windows.Forms.ErrorProvider errProviderID;
    }
}