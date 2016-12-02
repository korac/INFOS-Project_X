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
            this.lblUrediIme.Location = new System.Drawing.Point(78, 68);
            this.lblUrediIme.Name = "lblUrediIme";
            this.lblUrediIme.Size = new System.Drawing.Size(34, 17);
            this.lblUrediIme.TabIndex = 27;
            this.lblUrediIme.Text = "Ime:";
            // 
            // tboxIme
            // 
            this.tboxIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxIme.Location = new System.Drawing.Point(127, 68);
            this.tboxIme.Name = "tboxIme";
            this.tboxIme.Size = new System.Drawing.Size(206, 23);
            this.tboxIme.TabIndex = 26;
            this.tboxIme.Validating += new System.ComponentModel.CancelEventHandler(this.tboxIme_Validating);
            // 
            // lblUrediJezik
            // 
            this.lblUrediJezik.AutoSize = true;
            this.lblUrediJezik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrediJezik.Location = new System.Drawing.Point(68, 107);
            this.lblUrediJezik.Name = "lblUrediJezik";
            this.lblUrediJezik.Size = new System.Drawing.Size(44, 17);
            this.lblUrediJezik.TabIndex = 29;
            this.lblUrediJezik.Text = "Jezik:";
            // 
            // tboxJezik
            // 
            this.tboxJezik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxJezik.Location = new System.Drawing.Point(127, 104);
            this.tboxJezik.Name = "tboxJezik";
            this.tboxJezik.Size = new System.Drawing.Size(206, 23);
            this.tboxJezik.TabIndex = 28;
            this.tboxJezik.Validating += new System.ComponentModel.CancelEventHandler(this.tboxJezik_Validating);
            // 
            // lblUrediPozivni
            // 
            this.lblUrediPozivni.AutoSize = true;
            this.lblUrediPozivni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrediPozivni.Location = new System.Drawing.Point(27, 149);
            this.lblUrediPozivni.Name = "lblUrediPozivni";
            this.lblUrediPozivni.Size = new System.Drawing.Size(85, 17);
            this.lblUrediPozivni.TabIndex = 31;
            this.lblUrediPozivni.Text = "Pozivni broj:";
            // 
            // tboxPozivni
            // 
            this.tboxPozivni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxPozivni.Location = new System.Drawing.Point(127, 146);
            this.tboxPozivni.Name = "tboxPozivni";
            this.tboxPozivni.Size = new System.Drawing.Size(206, 23);
            this.tboxPozivni.TabIndex = 30;
            this.tboxPozivni.Validating += new System.ComponentModel.CancelEventHandler(this.tboxPozivni_Validating);
            // 
            // lblUrediValuta
            // 
            this.lblUrediValuta.AutoSize = true;
            this.lblUrediValuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUrediValuta.Location = new System.Drawing.Point(60, 188);
            this.lblUrediValuta.Name = "lblUrediValuta";
            this.lblUrediValuta.Size = new System.Drawing.Size(52, 17);
            this.lblUrediValuta.TabIndex = 33;
            this.lblUrediValuta.Text = "Valuta:";
            // 
            // tboxValuta
            // 
            this.tboxValuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxValuta.Location = new System.Drawing.Point(127, 185);
            this.tboxValuta.Name = "tboxValuta";
            this.tboxValuta.Size = new System.Drawing.Size(206, 23);
            this.tboxValuta.TabIndex = 32;
            this.tboxValuta.Validating += new System.ComponentModel.CancelEventHandler(this.tboxValuta_Validating);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(211, 237);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(101, 30);
            this.btnOdustani.TabIndex = 40;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnPrihvati
            // 
            this.btnPrihvati.Location = new System.Drawing.Point(93, 237);
            this.btnPrihvati.Name = "btnPrihvati";
            this.btnPrihvati.Size = new System.Drawing.Size(101, 30);
            this.btnPrihvati.TabIndex = 39;
            this.btnPrihvati.Text = "Prihvati";
            this.btnPrihvati.UseVisualStyleBackColor = true;
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
            this.lblDrzavaID.Location = new System.Drawing.Point(38, 32);
            this.lblDrzavaID.Name = "lblDrzavaID";
            this.lblDrzavaID.Size = new System.Drawing.Size(74, 17);
            this.lblDrzavaID.TabIndex = 42;
            this.lblDrzavaID.Text = "Drzava ID:";
            // 
            // tboxDrzavaID
            // 
            this.tboxDrzavaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxDrzavaID.Location = new System.Drawing.Point(127, 29);
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
            this.ClientSize = new System.Drawing.Size(379, 289);
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
            this.Name = "DodajUrediDrzavaForm";
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