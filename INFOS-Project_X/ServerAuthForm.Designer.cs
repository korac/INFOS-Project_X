namespace INFOS_Project_X
{
    partial class ServerAuthForm
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
            this.lblNazivServera = new System.Windows.Forms.Label();
            this.tboxNazivServera = new System.Windows.Forms.TextBox();
            this.tboxImeBaze = new System.Windows.Forms.TextBox();
            this.lblImeBaze = new System.Windows.Forms.Label();
            this.tboxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.tboxLozinka = new System.Windows.Forms.TextBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.btnSpoji = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.ckBox = new System.Windows.Forms.CheckBox();
            this.errProviderServer = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderBaza = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderKorisnicko = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderLozinka = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProviderServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderBaza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderKorisnicko)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderLozinka)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNazivServera
            // 
            this.lblNazivServera.AutoSize = true;
            this.lblNazivServera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivServera.Location = new System.Drawing.Point(43, 57);
            this.lblNazivServera.Name = "lblNazivServera";
            this.lblNazivServera.Size = new System.Drawing.Size(77, 13);
            this.lblNazivServera.TabIndex = 0;
            this.lblNazivServera.Text = "Naziv Servera:";
            // 
            // tboxNazivServera
            // 
            this.tboxNazivServera.Location = new System.Drawing.Point(126, 54);
            this.tboxNazivServera.Name = "tboxNazivServera";
            this.tboxNazivServera.Size = new System.Drawing.Size(237, 20);
            this.tboxNazivServera.TabIndex = 1;
            this.tboxNazivServera.Validating += new System.ComponentModel.CancelEventHandler(this.tboxNazivServera_Validating);
            // 
            // tboxImeBaze
            // 
            this.tboxImeBaze.Location = new System.Drawing.Point(126, 99);
            this.tboxImeBaze.Name = "tboxImeBaze";
            this.tboxImeBaze.Size = new System.Drawing.Size(237, 20);
            this.tboxImeBaze.TabIndex = 3;
            this.tboxImeBaze.Validating += new System.ComponentModel.CancelEventHandler(this.tboxImeBaze_Validating);
            // 
            // lblImeBaze
            // 
            this.lblImeBaze.AutoSize = true;
            this.lblImeBaze.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImeBaze.Location = new System.Drawing.Point(66, 102);
            this.lblImeBaze.Name = "lblImeBaze";
            this.lblImeBaze.Size = new System.Drawing.Size(54, 13);
            this.lblImeBaze.TabIndex = 2;
            this.lblImeBaze.Text = "Ime Baze:";
            // 
            // tboxKorisnickoIme
            // 
            this.tboxKorisnickoIme.Location = new System.Drawing.Point(126, 179);
            this.tboxKorisnickoIme.Name = "tboxKorisnickoIme";
            this.tboxKorisnickoIme.Size = new System.Drawing.Size(237, 20);
            this.tboxKorisnickoIme.TabIndex = 5;
            this.tboxKorisnickoIme.Validating += new System.ComponentModel.CancelEventHandler(this.tboxKorisnickoIme_Validating);
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKorisnickoIme.Location = new System.Drawing.Point(42, 182);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(78, 13);
            this.lblKorisnickoIme.TabIndex = 4;
            this.lblKorisnickoIme.Text = "Korisničko ime:";
            // 
            // tboxLozinka
            // 
            this.tboxLozinka.Location = new System.Drawing.Point(126, 224);
            this.tboxLozinka.Name = "tboxLozinka";
            this.tboxLozinka.PasswordChar = '*';
            this.tboxLozinka.Size = new System.Drawing.Size(237, 20);
            this.tboxLozinka.TabIndex = 7;
            this.tboxLozinka.Validating += new System.ComponentModel.CancelEventHandler(this.tboxLozinka_Validating);
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLozinka.Location = new System.Drawing.Point(64, 227);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(47, 13);
            this.lblLozinka.TabIndex = 6;
            this.lblLozinka.Text = "Lozinka:";
            // 
            // btnSpoji
            // 
            this.btnSpoji.Location = new System.Drawing.Point(104, 294);
            this.btnSpoji.Name = "btnSpoji";
            this.btnSpoji.Size = new System.Drawing.Size(134, 40);
            this.btnSpoji.TabIndex = 8;
            this.btnSpoji.Text = "Spoji";
            this.btnSpoji.UseVisualStyleBackColor = true;
            this.btnSpoji.Click += new System.EventHandler(this.btnSpoji_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(244, 294);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(134, 40);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // ckBox
            // 
            this.ckBox.AutoSize = true;
            this.ckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckBox.Location = new System.Drawing.Point(45, 141);
            this.ckBox.Name = "ckBox";
            this.ckBox.Size = new System.Drawing.Size(98, 17);
            this.ckBox.TabIndex = 11;
            this.ckBox.Text = "Windows Auth:";
            this.ckBox.UseVisualStyleBackColor = true;
            this.ckBox.CheckedChanged += new System.EventHandler(this.ckBox_CheckedChanged);
            // 
            // errProviderServer
            // 
            this.errProviderServer.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderServer.ContainerControl = this;
            // 
            // errProviderBaza
            // 
            this.errProviderBaza.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderBaza.ContainerControl = this;
            // 
            // errProviderKorisnicko
            // 
            this.errProviderKorisnicko.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderKorisnicko.ContainerControl = this;
            // 
            // errProviderLozinka
            // 
            this.errProviderLozinka.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderLozinka.ContainerControl = this;
            // 
            // ServerAuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 369);
            this.Controls.Add(this.ckBox);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpoji);
            this.Controls.Add(this.tboxLozinka);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.tboxKorisnickoIme);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Controls.Add(this.tboxImeBaze);
            this.Controls.Add(this.lblImeBaze);
            this.Controls.Add(this.tboxNazivServera);
            this.Controls.Add(this.lblNazivServera);
            this.Name = "ServerAuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server Authentication";
            this.Load += new System.EventHandler(this.ServerAuthForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProviderServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderBaza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderKorisnicko)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderLozinka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazivServera;
        private System.Windows.Forms.TextBox tboxNazivServera;
        private System.Windows.Forms.TextBox tboxImeBaze;
        private System.Windows.Forms.Label lblImeBaze;
        private System.Windows.Forms.TextBox tboxKorisnickoIme;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.TextBox tboxLozinka;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Button btnSpoji;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.CheckBox ckBox;
        private System.Windows.Forms.ErrorProvider errProviderServer;
        private System.Windows.Forms.ErrorProvider errProviderBaza;
        private System.Windows.Forms.ErrorProvider errProviderKorisnicko;
        private System.Windows.Forms.ErrorProvider errProviderLozinka;
    }
}