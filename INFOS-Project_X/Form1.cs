﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;

namespace INFOS_Project_X
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("Bravo!");
        }

        private void ClearMdiChildren()
        {
            foreach (var a in this.MdiChildren)
            {
                a.Close();
            }
        }

        private void tsmiClan_Click(object sender, EventArgs e)
        {
            menuItemClickHandler(MaticniPodaci.Clan);
        }

        private void tsmiDrustvo_Click(object sender, EventArgs e)
        {
            menuItemClickHandler(MaticniPodaci.Drustva);
        }

        private void tsmiMjesto_Click(object sender, EventArgs e)
        {
            menuItemClickHandler(MaticniPodaci.Mjesta);
        }

        private void tsmiDrzava_Click(object sender, EventArgs e)
        {
            menuItemClickHandler(MaticniPodaci.Drzave);
        }

        private void menuItemClickHandler(MaticniPodaci matpod)
        {
            MainScreenOff();
            ClearMdiChildren();
            Form2 newMDIChild               = new Form2(matpod, false);
            newMDIChild.MdiParent           = this;
            newMDIChild.WindowState         = FormWindowState.Maximized;
            newMDIChild                     .Show();
        }

        private void MainScreenOff()
        {
            panel.Visible = false;
        }

        private void tsmiClanovi_Click(object sender, EventArgs e)
        {
            UvozForm uvoz = new UvozForm(MaticniPodaci.Clan);
            if (uvoz.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Spremljeno u bazu");
            }
        }

        private void tsmiDrustva_Click(object sender, EventArgs e)
        {
            UvozForm uvoz = new UvozForm(MaticniPodaci.Drustva);
            if (uvoz.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Spremljeno u bazu");
            }
        }

        private void tsmiMjesta_Click(object sender, EventArgs e)
        {
            UvozForm uvoz = new UvozForm(MaticniPodaci.Mjesta);
            if (uvoz.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Spremljeno u bazu");
            }
        }

        private void tsmiDrzave_Click(object sender, EventArgs e)
        {
            UvozForm uvoz = new UvozForm(MaticniPodaci.Drzave);
            if (uvoz.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Spremljeno u bazu");
            }
        }

        private void tsmiIzlaz_Click(object sender, EventArgs e)
        {
            IzlazUpozorenjeForm izlaz   = new IzlazUpozorenjeForm();
            izlaz                       .ShowDialog();
        }

        
    }
}
