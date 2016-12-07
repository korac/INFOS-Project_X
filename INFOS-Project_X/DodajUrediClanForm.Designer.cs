namespace INFOS_Project_X
{
    partial class DodajUrediClanForm
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
            this.btnOdaberiMjesta = new System.Windows.Forms.Button();
            this.cboxMjesto = new System.Windows.Forms.ComboBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPrihvati = new System.Windows.Forms.Button();
            this.lblUrediOib = new System.Windows.Forms.Label();
            this.tboxOib = new System.Windows.Forms.TextBox();
            this.lblUrediZanimanje = new System.Windows.Forms.Label();
            this.tboxZanimanje = new System.Windows.Forms.TextBox();
            this.lblUrediMjesto = new System.Windows.Forms.Label();
            this.lblUrediDatumRodenja = new System.Windows.Forms.Label();
            this.tboxDatumRodenja = new System.Windows.Forms.TextBox();
            this.lblUrediPrezime = new System.Windows.Forms.Label();
            this.tboxPrezime = new System.Windows.Forms.TextBox();
            this.lblUrediIme = new System.Windows.Forms.Label();
            this.tboxIme = new System.Windows.Forms.TextBox();
            this.btnOdaberiDrustvo = new System.Windows.Forms.Button();
            this.cboxDrustvo = new System.Windows.Forms.ComboBox();
            this.lblUrediDrustvo = new System.Windows.Forms.Label();
            this.lblUrediTelefon = new System.Windows.Forms.Label();
            this.tboxTelefon = new System.Windows.Forms.TextBox();
            this.lblUrediEmail = new System.Windows.Forms.Label();
            this.tboxEmail = new System.Windows.Forms.TextBox();
            this.lblUrediAdresa = new System.Windows.Forms.Label();
            this.tboxAdresa = new System.Windows.Forms.TextBox();
            this.errProviderZanimanje = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderTelefon = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderAdresa = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderIme = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderPrezime = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderOIB = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderDatumRodenja = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProviderZanimanje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderTelefon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderAdresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderIme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderPrezime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderOIB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderDatumRodenja)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdaberiMjesta
            // 
            this.btnOdaberiMjesta.Location = new System.Drawing.Point(352, 341);
            this.btnOdaberiMjesta.Name = "btnOdaberiMjesta";
            this.btnOdaberiMjesta.Size = new System.Drawing.Size(30, 21);
            this.btnOdaberiMjesta.TabIndex = 50;
            this.btnOdaberiMjesta.Text = "...";
            this.btnOdaberiMjesta.UseVisualStyleBackColor = true;
            this.btnOdaberiMjesta.Click += new System.EventHandler(this.btnOdaberiMjesta_Click);
            // 
            // cboxMjesto
            // 
            this.cboxMjesto.FormattingEnabled = true;
            this.cboxMjesto.Location = new System.Drawing.Point(176, 341);
            this.cboxMjesto.Name = "cboxMjesto";
            this.cboxMjesto.Size = new System.Drawing.Size(170, 21);
            this.cboxMjesto.TabIndex = 49;
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.IndianRed;
            this.btnOdustani.FlatAppearance.BorderSize = 0;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Location = new System.Drawing.Point(281, 532);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(101, 42);
            this.btnOdustani.TabIndex = 48;
            this.btnOdustani.Text = "ODUSTANI";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnPrihvati
            // 
            this.btnPrihvati.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPrihvati.FlatAppearance.BorderSize = 0;
            this.btnPrihvati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrihvati.Location = new System.Drawing.Point(174, 532);
            this.btnPrihvati.Name = "btnPrihvati";
            this.btnPrihvati.Size = new System.Drawing.Size(101, 42);
            this.btnPrihvati.TabIndex = 47;
            this.btnPrihvati.Text = "PRIHVATI";
            this.btnPrihvati.UseVisualStyleBackColor = false;
            this.btnPrihvati.Click += new System.EventHandler(this.btnPrihvati_Click);
            // 
            // lblUrediOib
            // 
            this.lblUrediOib.AutoSize = true;
            this.lblUrediOib.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrediOib.ForeColor = System.Drawing.Color.LightGray;
            this.lblUrediOib.Location = new System.Drawing.Point(123, 146);
            this.lblUrediOib.Name = "lblUrediOib";
            this.lblUrediOib.Size = new System.Drawing.Size(35, 17);
            this.lblUrediOib.TabIndex = 46;
            this.lblUrediOib.Text = "OIB:";
            // 
            // tboxOib
            // 
            this.tboxOib.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxOib.Location = new System.Drawing.Point(176, 143);
            this.tboxOib.Name = "tboxOib";
            this.tboxOib.Size = new System.Drawing.Size(206, 23);
            this.tboxOib.TabIndex = 45;
            this.tboxOib.Validating += new System.ComponentModel.CancelEventHandler(this.tboxOib_Validating);
            // 
            // lblUrediZanimanje
            // 
            this.lblUrediZanimanje.AutoSize = true;
            this.lblUrediZanimanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrediZanimanje.ForeColor = System.Drawing.Color.LightGray;
            this.lblUrediZanimanje.Location = new System.Drawing.Point(69, 246);
            this.lblUrediZanimanje.Name = "lblUrediZanimanje";
            this.lblUrediZanimanje.Size = new System.Drawing.Size(89, 17);
            this.lblUrediZanimanje.TabIndex = 44;
            this.lblUrediZanimanje.Text = "ZANIMANJE:";
            // 
            // tboxZanimanje
            // 
            this.tboxZanimanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxZanimanje.Location = new System.Drawing.Point(176, 243);
            this.tboxZanimanje.Name = "tboxZanimanje";
            this.tboxZanimanje.Size = new System.Drawing.Size(206, 23);
            this.tboxZanimanje.TabIndex = 43;
            this.tboxZanimanje.Validating += new System.ComponentModel.CancelEventHandler(this.tboxZanimanje_Validating);
            // 
            // lblUrediMjesto
            // 
            this.lblUrediMjesto.AutoSize = true;
            this.lblUrediMjesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrediMjesto.ForeColor = System.Drawing.Color.LightGray;
            this.lblUrediMjesto.Location = new System.Drawing.Point(90, 341);
            this.lblUrediMjesto.Name = "lblUrediMjesto";
            this.lblUrediMjesto.Size = new System.Drawing.Size(68, 17);
            this.lblUrediMjesto.TabIndex = 42;
            this.lblUrediMjesto.Text = "MJESTO:";
            // 
            // lblUrediDatumRodenja
            // 
            this.lblUrediDatumRodenja.AutoSize = true;
            this.lblUrediDatumRodenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrediDatumRodenja.ForeColor = System.Drawing.Color.LightGray;
            this.lblUrediDatumRodenja.Location = new System.Drawing.Point(27, 194);
            this.lblUrediDatumRodenja.Name = "lblUrediDatumRodenja";
            this.lblUrediDatumRodenja.Size = new System.Drawing.Size(131, 17);
            this.lblUrediDatumRodenja.TabIndex = 41;
            this.lblUrediDatumRodenja.Text = "DATUM ROĐENJA:";
            // 
            // tboxDatumRodenja
            // 
            this.tboxDatumRodenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxDatumRodenja.Location = new System.Drawing.Point(176, 191);
            this.tboxDatumRodenja.Name = "tboxDatumRodenja";
            this.tboxDatumRodenja.Size = new System.Drawing.Size(206, 23);
            this.tboxDatumRodenja.TabIndex = 40;
            this.tboxDatumRodenja.Validating += new System.ComponentModel.CancelEventHandler(this.tboxDatumRodenja_Validating);
            // 
            // lblUrediPrezime
            // 
            this.lblUrediPrezime.AutoSize = true;
            this.lblUrediPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrediPrezime.ForeColor = System.Drawing.Color.LightGray;
            this.lblUrediPrezime.Location = new System.Drawing.Point(86, 95);
            this.lblUrediPrezime.Name = "lblUrediPrezime";
            this.lblUrediPrezime.Size = new System.Drawing.Size(72, 17);
            this.lblUrediPrezime.TabIndex = 39;
            this.lblUrediPrezime.Text = "PREZIME:";
            // 
            // tboxPrezime
            // 
            this.tboxPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxPrezime.Location = new System.Drawing.Point(176, 92);
            this.tboxPrezime.Name = "tboxPrezime";
            this.tboxPrezime.Size = new System.Drawing.Size(206, 23);
            this.tboxPrezime.TabIndex = 38;
            this.tboxPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.tboxPrezime_Validating);
            // 
            // lblUrediIme
            // 
            this.lblUrediIme.AutoSize = true;
            this.lblUrediIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrediIme.ForeColor = System.Drawing.Color.LightGray;
            this.lblUrediIme.Location = new System.Drawing.Point(123, 44);
            this.lblUrediIme.Name = "lblUrediIme";
            this.lblUrediIme.Size = new System.Drawing.Size(35, 17);
            this.lblUrediIme.TabIndex = 37;
            this.lblUrediIme.Text = "IME:";
            // 
            // tboxIme
            // 
            this.tboxIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxIme.Location = new System.Drawing.Point(176, 41);
            this.tboxIme.Name = "tboxIme";
            this.tboxIme.Size = new System.Drawing.Size(206, 23);
            this.tboxIme.TabIndex = 36;
            this.tboxIme.Validating += new System.ComponentModel.CancelEventHandler(this.tboxIme_Validating);
            // 
            // btnOdaberiDrustvo
            // 
            this.btnOdaberiDrustvo.Location = new System.Drawing.Point(352, 294);
            this.btnOdaberiDrustvo.Name = "btnOdaberiDrustvo";
            this.btnOdaberiDrustvo.Size = new System.Drawing.Size(30, 21);
            this.btnOdaberiDrustvo.TabIndex = 53;
            this.btnOdaberiDrustvo.Text = "...";
            this.btnOdaberiDrustvo.UseVisualStyleBackColor = true;
            this.btnOdaberiDrustvo.Click += new System.EventHandler(this.btnOdaberiDrustvo_Click);
            // 
            // cboxDrustvo
            // 
            this.cboxDrustvo.FormattingEnabled = true;
            this.cboxDrustvo.Location = new System.Drawing.Point(176, 294);
            this.cboxDrustvo.Name = "cboxDrustvo";
            this.cboxDrustvo.Size = new System.Drawing.Size(170, 21);
            this.cboxDrustvo.TabIndex = 52;
            // 
            // lblUrediDrustvo
            // 
            this.lblUrediDrustvo.AutoSize = true;
            this.lblUrediDrustvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrediDrustvo.ForeColor = System.Drawing.Color.LightGray;
            this.lblUrediDrustvo.Location = new System.Drawing.Point(78, 294);
            this.lblUrediDrustvo.Name = "lblUrediDrustvo";
            this.lblUrediDrustvo.Size = new System.Drawing.Size(80, 17);
            this.lblUrediDrustvo.TabIndex = 51;
            this.lblUrediDrustvo.Text = "DRUŠTVO:";
            // 
            // lblUrediTelefon
            // 
            this.lblUrediTelefon.AutoSize = true;
            this.lblUrediTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrediTelefon.ForeColor = System.Drawing.Color.LightGray;
            this.lblUrediTelefon.Location = new System.Drawing.Point(82, 390);
            this.lblUrediTelefon.Name = "lblUrediTelefon";
            this.lblUrediTelefon.Size = new System.Drawing.Size(76, 17);
            this.lblUrediTelefon.TabIndex = 55;
            this.lblUrediTelefon.Text = "TELEFON:";
            // 
            // tboxTelefon
            // 
            this.tboxTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxTelefon.Location = new System.Drawing.Point(176, 387);
            this.tboxTelefon.Name = "tboxTelefon";
            this.tboxTelefon.Size = new System.Drawing.Size(206, 23);
            this.tboxTelefon.TabIndex = 54;
            this.tboxTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.tboxTelefon_Validating);
            // 
            // lblUrediEmail
            // 
            this.lblUrediEmail.AutoSize = true;
            this.lblUrediEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrediEmail.ForeColor = System.Drawing.Color.LightGray;
            this.lblUrediEmail.Location = new System.Drawing.Point(106, 437);
            this.lblUrediEmail.Name = "lblUrediEmail";
            this.lblUrediEmail.Size = new System.Drawing.Size(52, 17);
            this.lblUrediEmail.TabIndex = 57;
            this.lblUrediEmail.Text = "EMAIL:";
            // 
            // tboxEmail
            // 
            this.tboxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxEmail.Location = new System.Drawing.Point(176, 434);
            this.tboxEmail.Name = "tboxEmail";
            this.tboxEmail.Size = new System.Drawing.Size(206, 23);
            this.tboxEmail.TabIndex = 56;
            // 
            // lblUrediAdresa
            // 
            this.lblUrediAdresa.AutoSize = true;
            this.lblUrediAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrediAdresa.ForeColor = System.Drawing.Color.LightGray;
            this.lblUrediAdresa.Location = new System.Drawing.Point(90, 483);
            this.lblUrediAdresa.Name = "lblUrediAdresa";
            this.lblUrediAdresa.Size = new System.Drawing.Size(68, 17);
            this.lblUrediAdresa.TabIndex = 59;
            this.lblUrediAdresa.Text = "ADRESA:";
            // 
            // tboxAdresa
            // 
            this.tboxAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxAdresa.Location = new System.Drawing.Point(176, 480);
            this.tboxAdresa.Name = "tboxAdresa";
            this.tboxAdresa.Size = new System.Drawing.Size(206, 23);
            this.tboxAdresa.TabIndex = 58;
            this.tboxAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.tboxAdresa_Validating);
            // 
            // errProviderZanimanje
            // 
            this.errProviderZanimanje.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderZanimanje.ContainerControl = this;
            // 
            // errProviderTelefon
            // 
            this.errProviderTelefon.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderTelefon.ContainerControl = this;
            // 
            // errProviderEmail
            // 
            this.errProviderEmail.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderEmail.ContainerControl = this;
            // 
            // errProviderAdresa
            // 
            this.errProviderAdresa.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderAdresa.ContainerControl = this;
            // 
            // errProviderIme
            // 
            this.errProviderIme.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderIme.ContainerControl = this;
            // 
            // errProviderPrezime
            // 
            this.errProviderPrezime.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderPrezime.ContainerControl = this;
            // 
            // errProviderOIB
            // 
            this.errProviderOIB.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderOIB.ContainerControl = this;
            // 
            // errProviderDatumRodenja
            // 
            this.errProviderDatumRodenja.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderDatumRodenja.ContainerControl = this;
            // 
            // DodajUrediClanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(461, 586);
            this.Controls.Add(this.lblUrediAdresa);
            this.Controls.Add(this.tboxAdresa);
            this.Controls.Add(this.lblUrediEmail);
            this.Controls.Add(this.tboxEmail);
            this.Controls.Add(this.lblUrediTelefon);
            this.Controls.Add(this.tboxTelefon);
            this.Controls.Add(this.btnOdaberiDrustvo);
            this.Controls.Add(this.cboxDrustvo);
            this.Controls.Add(this.lblUrediDrustvo);
            this.Controls.Add(this.btnOdaberiMjesta);
            this.Controls.Add(this.cboxMjesto);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPrihvati);
            this.Controls.Add(this.lblUrediOib);
            this.Controls.Add(this.tboxOib);
            this.Controls.Add(this.lblUrediZanimanje);
            this.Controls.Add(this.tboxZanimanje);
            this.Controls.Add(this.lblUrediMjesto);
            this.Controls.Add(this.lblUrediDatumRodenja);
            this.Controls.Add(this.tboxDatumRodenja);
            this.Controls.Add(this.lblUrediPrezime);
            this.Controls.Add(this.tboxPrezime);
            this.Controls.Add(this.lblUrediIme);
            this.Controls.Add(this.tboxIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DodajUrediClanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DodajUrediClanForm";
            this.Load += new System.EventHandler(this.DodajUrediClanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProviderZanimanje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderTelefon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderAdresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderIme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderPrezime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderOIB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderDatumRodenja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdaberiMjesta;
        private System.Windows.Forms.ComboBox cboxMjesto;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnPrihvati;
        private System.Windows.Forms.Label lblUrediOib;
        private System.Windows.Forms.TextBox tboxOib;
        private System.Windows.Forms.Label lblUrediZanimanje;
        private System.Windows.Forms.TextBox tboxZanimanje;
        private System.Windows.Forms.Label lblUrediMjesto;
        private System.Windows.Forms.Label lblUrediDatumRodenja;
        private System.Windows.Forms.TextBox tboxDatumRodenja;
        private System.Windows.Forms.Label lblUrediPrezime;
        private System.Windows.Forms.TextBox tboxPrezime;
        private System.Windows.Forms.Label lblUrediIme;
        private System.Windows.Forms.TextBox tboxIme;
        private System.Windows.Forms.Button btnOdaberiDrustvo;
        private System.Windows.Forms.ComboBox cboxDrustvo;
        private System.Windows.Forms.Label lblUrediDrustvo;
        private System.Windows.Forms.Label lblUrediTelefon;
        private System.Windows.Forms.TextBox tboxTelefon;
        private System.Windows.Forms.Label lblUrediEmail;
        private System.Windows.Forms.TextBox tboxEmail;
        private System.Windows.Forms.Label lblUrediAdresa;
        private System.Windows.Forms.TextBox tboxAdresa;
        private System.Windows.Forms.ErrorProvider errProviderZanimanje;
        private System.Windows.Forms.ErrorProvider errProviderTelefon;
        private System.Windows.Forms.ErrorProvider errProviderEmail;
        private System.Windows.Forms.ErrorProvider errProviderAdresa;
        private System.Windows.Forms.ErrorProvider errProviderIme;
        private System.Windows.Forms.ErrorProvider errProviderPrezime;
        private System.Windows.Forms.ErrorProvider errProviderOIB;
        private System.Windows.Forms.ErrorProvider errProviderDatumRodenja;
    }
}