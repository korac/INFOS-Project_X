namespace INFOS_Project_X
{
    partial class Form1
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
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiDatoteka = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIzlaz = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMaticniPodaci = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDrustvo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMjesto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDrzava = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProzor = new System.Windows.Forms.ToolStripMenuItem();
            this.infosXDatabaseDataSet1 = new INFOS_Project_X.infosXDatabaseDataSet();
            this.tsmiUvezi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infosXDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDatoteka,
            this.tsmiMaticniPodaci,
            this.tsmiProzor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.tsmiProzor;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(751, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "File";
            // 
            // tsmiDatoteka
            // 
            this.tsmiDatoteka.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUvezi,
            this.tsmiIzlaz});
            this.tsmiDatoteka.Name = "tsmiDatoteka";
            this.tsmiDatoteka.Size = new System.Drawing.Size(66, 20);
            this.tsmiDatoteka.Text = "Datoteka";
            // 
            // tsmiIzlaz
            // 
            this.tsmiIzlaz.Name = "tsmiIzlaz";
            this.tsmiIzlaz.Size = new System.Drawing.Size(152, 22);
            this.tsmiIzlaz.Text = "Izlaz";
            this.tsmiIzlaz.Click += new System.EventHandler(this.tsmiIzlaz_Click);
            // 
            // tsmiMaticniPodaci
            // 
            this.tsmiMaticniPodaci.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClan,
            this.tsmiDrustvo,
            this.tsmiMjesto,
            this.tsmiDrzava});
            this.tsmiMaticniPodaci.Name = "tsmiMaticniPodaci";
            this.tsmiMaticniPodaci.Size = new System.Drawing.Size(98, 20);
            this.tsmiMaticniPodaci.Text = "Matični Podaci";
            // 
            // tsmiClan
            // 
            this.tsmiClan.Name = "tsmiClan";
            this.tsmiClan.Size = new System.Drawing.Size(115, 22);
            this.tsmiClan.Text = "Član";
            this.tsmiClan.Click += new System.EventHandler(this.tsmiClan_Click);
            // 
            // tsmiDrustvo
            // 
            this.tsmiDrustvo.Name = "tsmiDrustvo";
            this.tsmiDrustvo.Size = new System.Drawing.Size(115, 22);
            this.tsmiDrustvo.Text = "Društvo";
            this.tsmiDrustvo.Click += new System.EventHandler(this.tsmiDrustvo_Click);
            // 
            // tsmiMjesto
            // 
            this.tsmiMjesto.Name = "tsmiMjesto";
            this.tsmiMjesto.Size = new System.Drawing.Size(115, 22);
            this.tsmiMjesto.Text = "Mjesto";
            this.tsmiMjesto.Click += new System.EventHandler(this.tsmiMjesto_Click);
            // 
            // tsmiDrzava
            // 
            this.tsmiDrzava.Name = "tsmiDrzava";
            this.tsmiDrzava.Size = new System.Drawing.Size(115, 22);
            this.tsmiDrzava.Text = "Država";
            this.tsmiDrzava.Click += new System.EventHandler(this.tsmiDrzava_Click);
            // 
            // tsmiProzor
            // 
            this.tsmiProzor.Name = "tsmiProzor";
            this.tsmiProzor.Size = new System.Drawing.Size(53, 20);
            this.tsmiProzor.Text = "Prozor";
            // 
            // infosXDatabaseDataSet1
            // 
            this.infosXDatabaseDataSet1.DataSetName = "infosXDatabaseDataSet";
            this.infosXDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tsmiUvezi
            // 
            this.tsmiUvezi.Name = "tsmiUvezi";
            this.tsmiUvezi.Size = new System.Drawing.Size(152, 22);
            this.tsmiUvezi.Text = "Uvezi";
            this.tsmiUvezi.Click += new System.EventHandler(this.tsmiUvezi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 375);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "INFOS Projekt X";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infosXDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private infosXDatabaseDataSet infosXDatabaseDataSet1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiProzor;
        private System.Windows.Forms.ToolStripMenuItem tsmiDatoteka;
        private System.Windows.Forms.ToolStripMenuItem tsmiIzlaz;
        private System.Windows.Forms.ToolStripMenuItem tsmiMaticniPodaci;
        private System.Windows.Forms.ToolStripMenuItem tsmiDrustvo;
        private System.Windows.Forms.ToolStripMenuItem tsmiMjesto;
        private System.Windows.Forms.ToolStripMenuItem tsmiDrzava;
        private System.Windows.Forms.ToolStripMenuItem tsmiClan;
        private System.Windows.Forms.ToolStripMenuItem tsmiUvezi;
    }
}

