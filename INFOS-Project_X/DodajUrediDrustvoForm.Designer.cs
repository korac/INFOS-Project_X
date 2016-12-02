namespace INFOS_Project_X
{
    partial class DodajUrediDrustvoForm
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
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPrihvati = new System.Windows.Forms.Button();
            this.lblUrediEmail = new System.Windows.Forms.Label();
            this.tboxEmail = new System.Windows.Forms.TextBox();
            this.lblUrediBrojRacuna = new System.Windows.Forms.Label();
            this.tboxBrojRacuna = new System.Windows.Forms.TextBox();
            this.lblUrediMjesto = new System.Windows.Forms.Label();
            this.lblUrediTelefon = new System.Windows.Forms.Label();
            this.tboxTelefon = new System.Windows.Forms.TextBox();
            this.lblUrediAdresa = new System.Windows.Forms.Label();
            this.tboxAdresa = new System.Windows.Forms.TextBox();
            this.lblUrediNaziv = new System.Windows.Forms.Label();
            this.tboxNaziv = new System.Windows.Forms.TextBox();
            this.cboxMjesto = new System.Windows.Forms.ComboBox();
            this.btnOdaberiMjesta = new System.Windows.Forms.Button();
            this.errProviderNaziv = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderAdresa = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderTelefon = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderBrojRacuna = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblDrustvoID = new System.Windows.Forms.Label();
            this.tboxDrustvoID = new System.Windows.Forms.TextBox();
            this.errProviderID = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProviderNaziv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderAdresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderTelefon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderBrojRacuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderID)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(245, 379);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(101, 30);
            this.btnOdustani.TabIndex = 33;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnPrihvati
            // 
            this.btnPrihvati.Location = new System.Drawing.Point(127, 379);
            this.btnPrihvati.Name = "btnPrihvati";
            this.btnPrihvati.Size = new System.Drawing.Size(101, 30);
            this.btnPrihvati.TabIndex = 32;
            this.btnPrihvati.Text = "Prihvati";
            this.btnPrihvati.UseVisualStyleBackColor = true;
            this.btnPrihvati.Click += new System.EventHandler(this.btnPrihvati_Click);
            // 
            // lblUrediEmail
            // 
            this.lblUrediEmail.AutoSize = true;
            this.lblUrediEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrediEmail.Location = new System.Drawing.Point(69, 176);
            this.lblUrediEmail.Name = "lblUrediEmail";
            this.lblUrediEmail.Size = new System.Drawing.Size(46, 17);
            this.lblUrediEmail.TabIndex = 31;
            this.lblUrediEmail.Text = "Email:";
            // 
            // tboxEmail
            // 
            this.tboxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxEmail.Location = new System.Drawing.Point(140, 173);
            this.tboxEmail.Name = "tboxEmail";
            this.tboxEmail.Size = new System.Drawing.Size(206, 23);
            this.tboxEmail.TabIndex = 30;
            // 
            // lblUrediBrojRacuna
            // 
            this.lblUrediBrojRacuna.AutoSize = true;
            this.lblUrediBrojRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrediBrojRacuna.Location = new System.Drawing.Point(30, 319);
            this.lblUrediBrojRacuna.Name = "lblUrediBrojRacuna";
            this.lblUrediBrojRacuna.Size = new System.Drawing.Size(85, 17);
            this.lblUrediBrojRacuna.TabIndex = 29;
            this.lblUrediBrojRacuna.Text = "Broj računa:";
            // 
            // tboxBrojRacuna
            // 
            this.tboxBrojRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxBrojRacuna.Location = new System.Drawing.Point(140, 316);
            this.tboxBrojRacuna.Name = "tboxBrojRacuna";
            this.tboxBrojRacuna.Size = new System.Drawing.Size(206, 23);
            this.tboxBrojRacuna.TabIndex = 28;
            this.tboxBrojRacuna.Validating += new System.ComponentModel.CancelEventHandler(this.tboxBrojRacuna_Validating);
            // 
            // lblUrediMjesto
            // 
            this.lblUrediMjesto.AutoSize = true;
            this.lblUrediMjesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrediMjesto.Location = new System.Drawing.Point(63, 269);
            this.lblUrediMjesto.Name = "lblUrediMjesto";
            this.lblUrediMjesto.Size = new System.Drawing.Size(53, 17);
            this.lblUrediMjesto.TabIndex = 27;
            this.lblUrediMjesto.Text = "Mjesto:";
            // 
            // lblUrediTelefon
            // 
            this.lblUrediTelefon.AutoSize = true;
            this.lblUrediTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrediTelefon.Location = new System.Drawing.Point(55, 222);
            this.lblUrediTelefon.Name = "lblUrediTelefon";
            this.lblUrediTelefon.Size = new System.Drawing.Size(60, 17);
            this.lblUrediTelefon.TabIndex = 25;
            this.lblUrediTelefon.Text = "Telefon:";
            // 
            // tboxTelefon
            // 
            this.tboxTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxTelefon.Location = new System.Drawing.Point(140, 219);
            this.tboxTelefon.Name = "tboxTelefon";
            this.tboxTelefon.Size = new System.Drawing.Size(206, 23);
            this.tboxTelefon.TabIndex = 24;
            this.tboxTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.tboxTelefon_Validating);
            // 
            // lblUrediAdresa
            // 
            this.lblUrediAdresa.AutoSize = true;
            this.lblUrediAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrediAdresa.Location = new System.Drawing.Point(58, 130);
            this.lblUrediAdresa.Name = "lblUrediAdresa";
            this.lblUrediAdresa.Size = new System.Drawing.Size(57, 17);
            this.lblUrediAdresa.TabIndex = 23;
            this.lblUrediAdresa.Text = "Adresa:";
            // 
            // tboxAdresa
            // 
            this.tboxAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxAdresa.Location = new System.Drawing.Point(140, 127);
            this.tboxAdresa.Name = "tboxAdresa";
            this.tboxAdresa.Size = new System.Drawing.Size(206, 23);
            this.tboxAdresa.TabIndex = 22;
            this.tboxAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.tboxAdresa_Validating);
            // 
            // lblUrediNaziv
            // 
            this.lblUrediNaziv.AutoSize = true;
            this.lblUrediNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrediNaziv.Location = new System.Drawing.Point(68, 85);
            this.lblUrediNaziv.Name = "lblUrediNaziv";
            this.lblUrediNaziv.Size = new System.Drawing.Size(47, 17);
            this.lblUrediNaziv.TabIndex = 21;
            this.lblUrediNaziv.Text = "Naziv:";
            // 
            // tboxNaziv
            // 
            this.tboxNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxNaziv.Location = new System.Drawing.Point(140, 82);
            this.tboxNaziv.Name = "tboxNaziv";
            this.tboxNaziv.Size = new System.Drawing.Size(206, 23);
            this.tboxNaziv.TabIndex = 20;
            this.tboxNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.tboxNaziv_Validating);
            // 
            // cboxMjesto
            // 
            this.cboxMjesto.FormattingEnabled = true;
            this.cboxMjesto.Location = new System.Drawing.Point(140, 269);
            this.cboxMjesto.Name = "cboxMjesto";
            this.cboxMjesto.Size = new System.Drawing.Size(170, 21);
            this.cboxMjesto.TabIndex = 34;
            // 
            // btnOdaberiMjesta
            // 
            this.btnOdaberiMjesta.Location = new System.Drawing.Point(316, 269);
            this.btnOdaberiMjesta.Name = "btnOdaberiMjesta";
            this.btnOdaberiMjesta.Size = new System.Drawing.Size(30, 21);
            this.btnOdaberiMjesta.TabIndex = 35;
            this.btnOdaberiMjesta.Text = "...";
            this.btnOdaberiMjesta.UseVisualStyleBackColor = true;
            this.btnOdaberiMjesta.Click += new System.EventHandler(this.btnOdaberiMjesta_Click);
            // 
            // errProviderNaziv
            // 
            this.errProviderNaziv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderNaziv.ContainerControl = this;
            // 
            // errProviderAdresa
            // 
            this.errProviderAdresa.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderAdresa.ContainerControl = this;
            // 
            // errProviderTelefon
            // 
            this.errProviderTelefon.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderTelefon.ContainerControl = this;
            // 
            // errProviderBrojRacuna
            // 
            this.errProviderBrojRacuna.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderBrojRacuna.ContainerControl = this;
            // 
            // lblDrustvoID
            // 
            this.lblDrustvoID.AutoSize = true;
            this.lblDrustvoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDrustvoID.Location = new System.Drawing.Point(37, 39);
            this.lblDrustvoID.Name = "lblDrustvoID";
            this.lblDrustvoID.Size = new System.Drawing.Size(78, 17);
            this.lblDrustvoID.TabIndex = 37;
            this.lblDrustvoID.Text = "Drustvo ID:";
            // 
            // tboxDrustvoID
            // 
            this.tboxDrustvoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxDrustvoID.Location = new System.Drawing.Point(140, 36);
            this.tboxDrustvoID.Name = "tboxDrustvoID";
            this.tboxDrustvoID.Size = new System.Drawing.Size(206, 23);
            this.tboxDrustvoID.TabIndex = 36;
            this.tboxDrustvoID.Validating += new System.ComponentModel.CancelEventHandler(this.tboxDrustvoID_Validating);
            // 
            // errProviderID
            // 
            this.errProviderID.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderID.ContainerControl = this;
            // 
            // DodajUrediDrustvoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 431);
            this.Controls.Add(this.lblDrustvoID);
            this.Controls.Add(this.tboxDrustvoID);
            this.Controls.Add(this.btnOdaberiMjesta);
            this.Controls.Add(this.cboxMjesto);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPrihvati);
            this.Controls.Add(this.lblUrediEmail);
            this.Controls.Add(this.tboxEmail);
            this.Controls.Add(this.lblUrediBrojRacuna);
            this.Controls.Add(this.tboxBrojRacuna);
            this.Controls.Add(this.lblUrediMjesto);
            this.Controls.Add(this.lblUrediTelefon);
            this.Controls.Add(this.tboxTelefon);
            this.Controls.Add(this.lblUrediAdresa);
            this.Controls.Add(this.tboxAdresa);
            this.Controls.Add(this.lblUrediNaziv);
            this.Controls.Add(this.tboxNaziv);
            this.Name = "DodajUrediDrustvoForm";
            this.Text = "UrediDrustvoForm";
            this.Load += new System.EventHandler(this.DodajUrediDrustvoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProviderNaziv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderAdresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderTelefon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderBrojRacuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnPrihvati;
        private System.Windows.Forms.Label lblUrediEmail;
        private System.Windows.Forms.TextBox tboxEmail;
        private System.Windows.Forms.Label lblUrediBrojRacuna;
        private System.Windows.Forms.TextBox tboxBrojRacuna;
        private System.Windows.Forms.Label lblUrediMjesto;
        private System.Windows.Forms.Label lblUrediTelefon;
        private System.Windows.Forms.TextBox tboxTelefon;
        private System.Windows.Forms.Label lblUrediAdresa;
        private System.Windows.Forms.TextBox tboxAdresa;
        private System.Windows.Forms.Label lblUrediNaziv;
        private System.Windows.Forms.TextBox tboxNaziv;
        private System.Windows.Forms.ComboBox cboxMjesto;
        private System.Windows.Forms.Button btnOdaberiMjesta;
        private System.Windows.Forms.ErrorProvider errProviderNaziv;
        private System.Windows.Forms.ErrorProvider errProviderAdresa;
        private System.Windows.Forms.ErrorProvider errProviderTelefon;
        private System.Windows.Forms.ErrorProvider errProviderBrojRacuna;
        private System.Windows.Forms.Label lblDrustvoID;
        private System.Windows.Forms.TextBox tboxDrustvoID;
        private System.Windows.Forms.ErrorProvider errProviderID;
    }
}