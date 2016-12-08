namespace INFOS_Project_X
{
    partial class DodajUrediDrzavaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajUrediDrzavaForm));
            this.lblUrediIme = new System.Windows.Forms.Label();
            this.tboxIme = new System.Windows.Forms.TextBox();
            this.lblUrediJezik = new System.Windows.Forms.Label();
            this.tboxJezik = new System.Windows.Forms.TextBox();
            this.lblUrediPozivni = new System.Windows.Forms.Label();
            this.tboxPozivni = new System.Windows.Forms.TextBox();
            this.lblUrediValuta = new System.Windows.Forms.Label();
            this.tboxValuta = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnPrihvati = new System.Windows.Forms.Button();
            this.errProviderIme = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderJezik = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderPozivni = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderValuta = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblDrzavaID = new System.Windows.Forms.Label();
            this.tboxDrzavaID = new System.Windows.Forms.TextBox();
            this.errProviderID = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProviderIme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderJezik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderPozivni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderValuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderID)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrediIme
            // 
            this.lblUrediIme.AutoSize = true;
            this.lblUrediIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrediIme.ForeColor = System.Drawing.Color.LightGray;
            this.lblUrediIme.Location = new System.Drawing.Point(97, 61);
            this.lblUrediIme.Name = "lblUrediIme";
            this.lblUrediIme.Size = new System.Drawing.Size(35, 17);
            this.lblUrediIme.TabIndex = 27;
            this.lblUrediIme.Text = "IME:";
            // 
            // tboxIme
            // 
            this.tboxIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxIme.Location = new System.Drawing.Point(138, 58);
            this.tboxIme.MaxLength = 50;
            this.tboxIme.Name = "tboxIme";
            this.tboxIme.Size = new System.Drawing.Size(206, 23);
            this.tboxIme.TabIndex = 26;
            this.tboxIme.Validating += new System.ComponentModel.CancelEventHandler(this.tboxIme_Validating);
            // 
            // lblUrediJezik
            // 
            this.lblUrediJezik.AutoSize = true;
            this.lblUrediJezik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrediJezik.ForeColor = System.Drawing.Color.LightGray;
            this.lblUrediJezik.Location = new System.Drawing.Point(83, 104);
            this.lblUrediJezik.Name = "lblUrediJezik";
            this.lblUrediJezik.Size = new System.Drawing.Size(49, 17);
            this.lblUrediJezik.TabIndex = 29;
            this.lblUrediJezik.Text = "JEZIK:";
            // 
            // tboxJezik
            // 
            this.tboxJezik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxJezik.Location = new System.Drawing.Point(138, 101);
            this.tboxJezik.MaxLength = 50;
            this.tboxJezik.Name = "tboxJezik";
            this.tboxJezik.Size = new System.Drawing.Size(206, 23);
            this.tboxJezik.TabIndex = 28;
            this.tboxJezik.Validating += new System.ComponentModel.CancelEventHandler(this.tboxJezik_Validating);
            // 
            // lblUrediPozivni
            // 
            this.lblUrediPozivni.AutoSize = true;
            this.lblUrediPozivni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrediPozivni.ForeColor = System.Drawing.Color.LightGray;
            this.lblUrediPozivni.Location = new System.Drawing.Point(25, 133);
            this.lblUrediPozivni.Name = "lblUrediPozivni";
            this.lblUrediPozivni.Size = new System.Drawing.Size(107, 17);
            this.lblUrediPozivni.TabIndex = 31;
            this.lblUrediPozivni.Text = "POZIVNI BROJ:";
            // 
            // tboxPozivni
            // 
            this.tboxPozivni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxPozivni.Location = new System.Drawing.Point(138, 130);
            this.tboxPozivni.MaxLength = 20;
            this.tboxPozivni.Name = "tboxPozivni";
            this.tboxPozivni.Size = new System.Drawing.Size(206, 23);
            this.tboxPozivni.TabIndex = 30;
            this.tboxPozivni.Validating += new System.ComponentModel.CancelEventHandler(this.tboxPozivni_Validating);
            // 
            // lblUrediValuta
            // 
            this.lblUrediValuta.AutoSize = true;
            this.lblUrediValuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrediValuta.ForeColor = System.Drawing.Color.LightGray;
            this.lblUrediValuta.Location = new System.Drawing.Point(66, 163);
            this.lblUrediValuta.Name = "lblUrediValuta";
            this.lblUrediValuta.Size = new System.Drawing.Size(66, 17);
            this.lblUrediValuta.TabIndex = 33;
            this.lblUrediValuta.Text = "VALUTA:";
            // 
            // tboxValuta
            // 
            this.tboxValuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxValuta.Location = new System.Drawing.Point(138, 160);
            this.tboxValuta.MaxLength = 30;
            this.tboxValuta.Name = "tboxValuta";
            this.tboxValuta.Size = new System.Drawing.Size(206, 23);
            this.tboxValuta.TabIndex = 32;
            this.tboxValuta.Validating += new System.ComponentModel.CancelEventHandler(this.tboxValuta_Validating);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.IndianRed;
            this.btnOdustani.FlatAppearance.BorderSize = 0;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.ForeColor = System.Drawing.Color.White;
            this.btnOdustani.Location = new System.Drawing.Point(243, 204);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(101, 42);
            this.btnOdustani.TabIndex = 40;
            this.btnOdustani.Text = "ODUSTANI";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnPrihvati
            // 
            this.btnPrihvati.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPrihvati.FlatAppearance.BorderSize = 0;
            this.btnPrihvati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrihvati.ForeColor = System.Drawing.Color.White;
            this.btnPrihvati.Location = new System.Drawing.Point(136, 204);
            this.btnPrihvati.Name = "btnPrihvati";
            this.btnPrihvati.Size = new System.Drawing.Size(101, 42);
            this.btnPrihvati.TabIndex = 39;
            this.btnPrihvati.Text = "PRIHVATI";
            this.btnPrihvati.UseVisualStyleBackColor = false;
            this.btnPrihvati.Click += new System.EventHandler(this.btnPrihvati_Click);
            // 
            // errProviderIme
            // 
            this.errProviderIme.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderIme.ContainerControl = this;
            // 
            // errProviderJezik
            // 
            this.errProviderJezik.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderJezik.ContainerControl = this;
            // 
            // errProviderPozivni
            // 
            this.errProviderPozivni.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderPozivni.ContainerControl = this;
            // 
            // errProviderValuta
            // 
            this.errProviderValuta.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderValuta.ContainerControl = this;
            // 
            // lblDrzavaID
            // 
            this.lblDrzavaID.AutoSize = true;
            this.lblDrzavaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDrzavaID.ForeColor = System.Drawing.Color.LightGray;
            this.lblDrzavaID.Location = new System.Drawing.Point(21, 32);
            this.lblDrzavaID.Name = "lblDrzavaID";
            this.lblDrzavaID.Size = new System.Drawing.Size(111, 17);
            this.lblDrzavaID.TabIndex = 42;
            this.lblDrzavaID.Text = "ŠIFRA DRŽAVE:";
            // 
            // tboxDrzavaID
            // 
            this.tboxDrzavaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxDrzavaID.Location = new System.Drawing.Point(138, 29);
            this.tboxDrzavaID.MaxLength = 50;
            this.tboxDrzavaID.Name = "tboxDrzavaID";
            this.tboxDrzavaID.Size = new System.Drawing.Size(206, 23);
            this.tboxDrzavaID.TabIndex = 41;
            this.tboxDrzavaID.Validating += new System.ComponentModel.CancelEventHandler(this.tboxDrzavaID_Validating);
            // 
            // errProviderID
            // 
            this.errProviderID.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderID.ContainerControl = this;
            // 
            // DodajUrediDrzavaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(379, 265);
            this.Controls.Add(this.lblDrzavaID);
            this.Controls.Add(this.tboxDrzavaID);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPrihvati);
            this.Controls.Add(this.lblUrediValuta);
            this.Controls.Add(this.tboxValuta);
            this.Controls.Add(this.lblUrediPozivni);
            this.Controls.Add(this.tboxPozivni);
            this.Controls.Add(this.lblUrediJezik);
            this.Controls.Add(this.tboxJezik);
            this.Controls.Add(this.lblUrediIme);
            this.Controls.Add(this.tboxIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajUrediDrzavaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DodajUrediDrzavaForm";
            this.Load += new System.EventHandler(this.DodajUrediDrzavaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProviderIme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderJezik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderPozivni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderValuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrediIme;
        private System.Windows.Forms.TextBox tboxIme;
        private System.Windows.Forms.Label lblUrediJezik;
        private System.Windows.Forms.TextBox tboxJezik;
        private System.Windows.Forms.Label lblUrediPozivni;
        private System.Windows.Forms.TextBox tboxPozivni;
        private System.Windows.Forms.Label lblUrediValuta;
        private System.Windows.Forms.TextBox tboxValuta;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnPrihvati;
        private System.Windows.Forms.ErrorProvider errProviderIme;
        private System.Windows.Forms.ErrorProvider errProviderJezik;
        private System.Windows.Forms.ErrorProvider errProviderPozivni;
        private System.Windows.Forms.ErrorProvider errProviderValuta;
        private System.Windows.Forms.Label lblDrzavaID;
        private System.Windows.Forms.TextBox tboxDrzavaID;
        private System.Windows.Forms.ErrorProvider errProviderID;
    }
}