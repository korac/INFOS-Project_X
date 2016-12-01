using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace INFOS_Project_X
{
    public partial class UvozForm : Form
    {
        infosXDatabaseDataSet ds                                                = new infosXDatabaseDataSet();
        infosXDatabaseDataSetTableAdapters.ClanTableAdapter clanTA              = new infosXDatabaseDataSetTableAdapters.ClanTableAdapter();
        infosXDatabaseDataSetTableAdapters.DrustvoTableAdapter drustvoTA        = new infosXDatabaseDataSetTableAdapters.DrustvoTableAdapter();
        infosXDatabaseDataSetTableAdapters.MjestoTableAdapter mjestoTA          = new infosXDatabaseDataSetTableAdapters.MjestoTableAdapter();
        infosXDatabaseDataSetTableAdapters.DrzavaTableAdapter drzavaTA          = new infosXDatabaseDataSetTableAdapters.DrzavaTableAdapter();
        public UvozForm()
        {
            InitializeComponent();

            dgvUvoz.AutoGenerateColumns                 = false;
        }

        private void btnUveziClanove_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openXml                  = new OpenFileDialog();

                if (openXml.ShowDialog() == DialogResult.OK)
                {
                    btnUveziClanove.Visible             = false;
                    btnUveziDrustva.Visible             = false;
                    btnUveziMjesta.Visible              = false;
                    btnUveziDrzave.Visible              = false;

                    btnPohrani.Visible                  = true;
                    btnOdustani.Visible                 = true;
                    dgvUvoz.Visible                     = true;

                    XDocument xmlDoc                    = XDocument.Load(openXml.FileName);

                    foreach (var i in xmlDoc.Descendants("Clan"))
                    {
                        infosXDatabaseDataSet.ClanRow clanRow   = ds.Clan.NewClanRow();

                        clanRow.OIB                     = i.Element("OIB").Value;
                        clanRow.Ime                     = i.Element("Ime").Value;
                        clanRow.Prezime                 = i.Element("Prezime").Value;
                        clanRow.DatumRodenja            = Convert.ToDateTime(i.Element("DatumRodenja").Value);
                        clanRow.Zanimanje               = (i.Element("Zanimanje").Value != "") ? i.Element("Zanimanje").Value : "";
                        clanRow.Drustvo_ID              = Convert.ToInt16(i.Element("Drustvo_ID").Value);
                        clanRow.Mjesto_ID               = Convert.ToInt16((i.Element("Mjesto_ID").Value != "") ? i.Element("Mjesto_ID").Value : null);
                        clanRow.Email                   = (i.Element("Email").Value != "") ? i.Element("Email").Value : "";
                        clanRow.Adresa                  = (i.Element("Adresa").Value != "") ? i.Element("Adresa").Value : "";
                        clanRow.Telefon                 = (i.Element("Telefon").Value != "") ? i.Element("Telefon").Value : "";

                        ds.Clan                         .AddClanRow(clanRow);
                    }

                    PomocneFunkcije                     .AutoSizeDgvColumns(dgvUvoz.Columns);
                    dgvUvoz.DataSource                  = ds.Clan;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }


        private void btnUveziDrustva_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog  openXml                 = new OpenFileDialog();
                
                if(openXml.ShowDialog() == DialogResult.OK)
                {
                    btnUveziClanove.Visible             = false;
                    btnUveziDrustva.Visible             = false;
                    btnUveziMjesta.Visible              = false;
                    btnUveziDrzave.Visible              = false;

                    btnPohrani.Visible                  = true;
                    btnOdustani.Visible                 = true;
                    dgvUvoz.Visible                     = true;

                    XDocument xmlDoc                    = XDocument.Load(openXml.FileName);

                    foreach(var i in xmlDoc.Descendants("Drustvo"))
                    {
                        infosXDatabaseDataSet.DrustvoRow drustvoRow    = ds.Drustvo.NewDrustvoRow();

                        drustvoRow.ID                   = Convert.ToInt16(i.Element("ID").Value);
                        drustvoRow.Naziv                = i.Element("Naziv").Value;
                        drustvoRow.Adresa               = (i.Element("Adresa").Value != "") ? i.Element("Adresa").Value : ""; //null
                        drustvoRow.Email                = (i.Element("Email").Value != "") ? i.Element("Email").Value : ""; //null
                        drustvoRow.Mjesto_ID            = Convert.ToInt16(i.Element("Mjesto_ID").Value);
                        drustvoRow.BrojRacuna           = (i.Element("BrojRacuna").Value != "") ? i.Element("BrojRacuna").Value : ""; //null
                        drustvoRow.Telefon              = (i.Element("Telefon").Value != "") ? i.Element("Telefon").Value : ""; //null

                        ds.Drustvo                      .AddDrustvoRow(drustvoRow);
                    }

                    PomocneFunkcije                     .AutoSizeDgvColumns(dgvUvoz.Columns);
                    dgvUvoz.DataSource                  = ds.Drustvo;
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void btnUveziMjesta_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openXml                  = new OpenFileDialog();

                if(openXml.ShowDialog() == DialogResult.OK)
                {
                    btnUveziClanove.Visible             = false;
                    btnUveziDrustva.Visible             = false;
                    btnUveziMjesta.Visible              = false;
                    btnUveziDrzave.Visible              = false;

                    btnPohrani.Visible                  = true;
                    btnOdustani.Visible                 = true;
                    dgvUvoz.Visible                     = true;

                    XDocument xmlDoc                    = XDocument.Load(openXml.FileName);

                    foreach(var i in xmlDoc.Descendants("Mjesto"))
                    {
                        infosXDatabaseDataSet.MjestoRow mjestoRow       = ds.Mjesto.NewMjestoRow();

                        mjestoRow.ID                    = Convert.ToInt16(i.Element("ID").Value);
                        mjestoRow.Ime                   = i.Element("Ime").Value;
                        mjestoRow.Drzava_ID             = Convert.ToInt16(i.Element("Drzava_ID").Value);
                        
                        ds.Mjesto                       .AddMjestoRow(mjestoRow);
                    }

                    PomocneFunkcije                     .AutoSizeDgvColumns(dgvUvoz.Columns);
                    dgvUvoz.DataSource                  = ds.Mjesto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void btnUveziDrzave_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openXml                  = new OpenFileDialog();

                if(openXml.ShowDialog() == DialogResult.OK)
                {
                    btnUveziClanove.Visible             = false;
                    btnUveziDrustva.Visible             = false;
                    btnUveziMjesta.Visible              = false;
                    btnUveziDrzave.Visible              = false;

                    btnPohrani.Visible                  = true;
                    btnOdustani.Visible                 = true;
                    dgvUvoz.Visible                     = true;

                    XDocument xmlDoc                    = XDocument.Load(openXml.FileName);

                    foreach(var i in xmlDoc.Descendants("Drzava"))
                    {
                        infosXDatabaseDataSet.DrzavaRow drzavaRow       = ds.Drzava.NewDrzavaRow();

                        drzavaRow.ID                    = Convert.ToInt16(i.Element("ID").Value);
                        drzavaRow.Ime                   = i.Element("Ime").Value;
                        drzavaRow.Jezik                 = i.Element("Jezik").Value;
                        drzavaRow.PozivniBroj           = i.Element("PozivniBroj").Value;
                        drzavaRow.Valuta                = i.Element("Valuta").Value;

                        ds.Drzava                       .AddDrzavaRow(drzavaRow);
                    }
                    
                    PomocneFunkcije                     .AutoSizeDgvColumns(dgvUvoz.Columns);
                    dgvUvoz.DataSource                  = ds.Drzava;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void btnPohrani_Click(object sender, EventArgs e)
        {
            if (dgvUvoz.DataSource == ds.Clan)
            {
                clanTA.Update(ds.Clan);
                ds.AcceptChanges();
            }
            
            if(dgvUvoz.DataSource == ds.Drustvo)
            {
                drustvoTA.Update(ds.Drustvo);
                ds.AcceptChanges();
            }

            if (dgvUvoz.DataSource == ds.Mjesto)
            {
                mjestoTA.Update(ds.Mjesto);
                ds.AcceptChanges();
            }

            if (dgvUvoz.DataSource == ds.Drzava)
            {
                drzavaTA.Update(ds.Drzava);
                ds.AcceptChanges();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
