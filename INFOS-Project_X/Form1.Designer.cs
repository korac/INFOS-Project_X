﻿namespace INFOS_Project_X
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiDatoteka = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUvezi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClanovi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDrustva = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMjesta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDrzave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIzlaz = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMaticniPodaci = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDrustvo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMjesto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDrzava = new System.Windows.Forms.ToolStripMenuItem();
            this.infosXDatabaseDataSet1 = new INFOS_Project_X.infosXDatabaseDataSet();
            this.panel = new System.Windows.Forms.Panel();
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
            this.tsmiMaticniPodaci});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
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
            // tsmiUvezi
            // 
            this.tsmiUvezi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClanovi,
            this.tsmiDrustva,
            this.tsmiMjesta,
            this.tsmiDrzave});
            this.tsmiUvezi.Name = "tsmiUvezi";
            this.tsmiUvezi.Size = new System.Drawing.Size(102, 22);
            this.tsmiUvezi.Text = "Uvezi";
            // 
            // tsmiClanovi
            // 
            this.tsmiClanovi.Name = "tsmiClanovi";
            this.tsmiClanovi.Size = new System.Drawing.Size(114, 22);
            this.tsmiClanovi.Text = "Članovi";
            this.tsmiClanovi.Click += new System.EventHandler(this.tsmiClanovi_Click);
            // 
            // tsmiDrustva
            // 
            this.tsmiDrustva.Name = "tsmiDrustva";
            this.tsmiDrustva.Size = new System.Drawing.Size(114, 22);
            this.tsmiDrustva.Text = "Društva";
            this.tsmiDrustva.Click += new System.EventHandler(this.tsmiDrustva_Click);
            // 
            // tsmiMjesta
            // 
            this.tsmiMjesta.Name = "tsmiMjesta";
            this.tsmiMjesta.Size = new System.Drawing.Size(114, 22);
            this.tsmiMjesta.Text = "Mjesta";
            this.tsmiMjesta.Click += new System.EventHandler(this.tsmiMjesta_Click);
            // 
            // tsmiDrzave
            // 
            this.tsmiDrzave.Name = "tsmiDrzave";
            this.tsmiDrzave.Size = new System.Drawing.Size(114, 22);
            this.tsmiDrzave.Text = "Države";
            this.tsmiDrzave.Click += new System.EventHandler(this.tsmiDrzave_Click);
            // 
            // tsmiIzlaz
            // 
            this.tsmiIzlaz.Name = "tsmiIzlaz";
            this.tsmiIzlaz.Size = new System.Drawing.Size(102, 22);
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
            // infosXDatabaseDataSet1
            // 
            this.infosXDatabaseDataSet1.DataSetName = "infosXDatabaseDataSet";
            this.infosXDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 24);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(751, 351);
            this.panel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(751, 375);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ToolStripMenuItem tsmiDatoteka;
        private System.Windows.Forms.ToolStripMenuItem tsmiIzlaz;
        private System.Windows.Forms.ToolStripMenuItem tsmiMaticniPodaci;
        private System.Windows.Forms.ToolStripMenuItem tsmiDrustvo;
        private System.Windows.Forms.ToolStripMenuItem tsmiMjesto;
        private System.Windows.Forms.ToolStripMenuItem tsmiDrzava;
        private System.Windows.Forms.ToolStripMenuItem tsmiClan;
        private System.Windows.Forms.ToolStripMenuItem tsmiUvezi;
        private System.Windows.Forms.ToolStripMenuItem tsmiClanovi;
        private System.Windows.Forms.ToolStripMenuItem tsmiDrustva;
        private System.Windows.Forms.ToolStripMenuItem tsmiMjesta;
        private System.Windows.Forms.ToolStripMenuItem tsmiDrzave;
        private System.Windows.Forms.Panel panel;
    }
}

