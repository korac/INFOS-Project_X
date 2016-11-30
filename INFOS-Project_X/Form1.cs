using System;
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
            ClearMdiChildren();
            Form2 newMDIChild       = new Form2(matpod, false);
            // Set the Parent Form of the Child window
            newMDIChild.MdiParent   = this;
            // Display the new form
            newMDIChild.Show();
            newMDIChild.WindowState = FormWindowState.Maximized;
        }

        private void tsmiUvezi_Click(object sender, EventArgs e)
        {
            UvozForm uvoz           = new UvozForm();
            if(uvoz.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Spremljeno u bazu");
            }
        }

        private void tsmiIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
