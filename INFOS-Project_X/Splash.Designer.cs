namespace INFOS_Project_X
{
    partial class Splash
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
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblSpajanje = new System.Windows.Forms.Label();
            this.bworker = new System.ComponentModel.BackgroundWorker();
            this.lblProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNaslov.Location = new System.Drawing.Point(282, 9);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(256, 31);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "INFOS - Project_X";
            // 
            // lblSpajanje
            // 
            this.lblSpajanje.AutoSize = true;
            this.lblSpajanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSpajanje.Location = new System.Drawing.Point(12, 341);
            this.lblSpajanje.Name = "lblSpajanje";
            this.lblSpajanje.Size = new System.Drawing.Size(139, 17);
            this.lblSpajanje.TabIndex = 1;
            this.lblSpajanje.Text = "Spajanje na server...";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(12, 328);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(48, 13);
            this.lblProgress.TabIndex = 2;
            this.lblProgress.Text = "Progress";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::INFOS_Project_X.Properties.Resources.water_splash_png_23;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 367);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.lblSpajanje);
            this.Controls.Add(this.lblNaslov);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblSpajanje;
        private System.ComponentModel.BackgroundWorker bworker;
        private System.Windows.Forms.Label lblProgress;
    }
}