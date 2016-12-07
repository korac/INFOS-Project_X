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

        MaticniPodaci _maticniPodaci;

        public UvozForm(MaticniPodaci maticniPodaci)
        {
            InitializeComponent();

            _maticniPodaci      = maticniPodaci;
        }

        private void UvozForm_Load(object sender, EventArgs e)
        {
            btnPohrani.Visible      = true;
            btnOdustani.Visible     = true;

            try
            {
                OpenFileDialog openXml  = new OpenFileDialog();

                if(openXml.ShowDialog() == DialogResult.OK)
                {
                    XDocument xmlDoc    = XDocument.Load(openXml.FileName);

                    switch (_maticniPodaci)
                    {
                        case MaticniPodaci.Clan:

                            foreach (var i in xmlDoc.Descendants("Clan"))
                            {
                                infosXDatabaseDataSet.ClanRow clanRow   = ds.Clan.NewClanRow();

                                clanRow.OIB             = i.Element("OIB").Value;
                                clanRow.Ime             = i.Element("Ime").Value;
                                clanRow.Prezime         = i.Element("Prezime").Value;
                                clanRow.DatumRodenja    = Convert.ToDateTime(i.Element("DatumRodenja").Value);
                                clanRow.Zanimanje       = (i.Element("Zanimanje").Value != "") ? i.Element("Zanimanje").Value : "";
                                clanRow.Drustvo_ID      = i.Element("Drustvo_ID").Value;
                                clanRow.Mjesto_ID       = (i.Element("Mjesto_ID").Value != "") ? i.Element("Mjesto_ID").Value : null;
                                clanRow.Email           = (i.Element("Email").Value != "") ? i.Element("Email").Value : "";
                                clanRow.Adresa          = (i.Element("Adresa").Value != "") ? i.Element("Adresa").Value : "";
                                clanRow.Telefon         = (i.Element("Telefon").Value != "") ? i.Element("Telefon").Value : "";

                                ds.Clan                 .AddClanRow(clanRow);
                            }

                            dgvUvoz.DataSource          = ds.Clan;
                            break;

                        case MaticniPodaci.Drustva:

                            int j = 1;
                            foreach(var i in xmlDoc.Descendants("Drustvo"))
                            {
                                infosXDatabaseDataSet.DrustvoRow drustvoRow    = ds.Drustvo.NewDrustvoRow();

                                drustvoRow.ID           = "drustvo" + j;
                                drustvoRow.Naziv        = i.Element("Naziv").Value;
                                drustvoRow.Adresa       = (i.Element("Adresa").Value != "") ? i.Element("Adresa").Value : ""; //null
                                drustvoRow.Email        = (i.Element("Email").Value != "") ? i.Element("Email").Value : ""; //null
                                drustvoRow.Mjesto_ID    = i.Element("Mjesto_ID").Value;
                                drustvoRow.BrojRacuna   = (i.Element("BrojRacuna").Value != "") ? i.Element("BrojRacuna").Value : ""; //null
                                drustvoRow.Telefon      = (i.Element("Telefon").Value != "") ? i.Element("Telefon").Value : ""; //null

                                ds.Drustvo              .AddDrustvoRow(drustvoRow);
                                j++;
                            }

                            dgvUvoz.DataSource          = ds.Drustvo;
                            break;

                        case MaticniPodaci.Mjesta:

                            int k = 1;
                            foreach(var i in xmlDoc.Descendants("Mjesto"))
                            {
                                infosXDatabaseDataSet.MjestoRow mjestoRow   = ds.Mjesto.NewMjestoRow();

                                mjestoRow.ID            = "mjesto" + k;
                                mjestoRow.Ime           = i.Element("Ime").Value;
                                mjestoRow.Drzava_ID     = i.Element("Drzava_ID").Value;
                        
                                ds.Mjesto               .AddMjestoRow(mjestoRow);
                                k++;
                            }

                            dgvUvoz.DataSource          = ds.Mjesto;
                            break;

                        case MaticniPodaci.Drzave:

                            int p = 1;
                            foreach(var i in xmlDoc.Descendants("Drzava"))
                            {
                                infosXDatabaseDataSet.DrzavaRow drzavaRow   = ds.Drzava.NewDrzavaRow();

                                drzavaRow.ID            = "drzava" + p;
                                drzavaRow.Ime           = i.Element("Ime").Value;
                                drzavaRow.Jezik         = i.Element("Jezik").Value;
                                drzavaRow.PozivniBroj   = i.Element("PozivniBroj").Value;
                                drzavaRow.Valuta        = i.Element("Valuta").Value;

                                ds.Drzava               .AddDrzavaRow(drzavaRow);

                                p++;
                            }
                    
                            dgvUvoz.DataSource          = ds.Drzava;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška s uvozom vanjske XML datoteke: " + ex.Message);
            }
     
        }

        private void btnPohrani_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUvoz.DataSource == ds.Clan)
                {
                    clanTA          .Update(ds.Clan);
                    MessageBox      .Show("Zapis je uspješno uvezen");
                    ds              .AcceptChanges();

                    this            .Close();
                }
            
                if(dgvUvoz.DataSource == ds.Drustvo)
                {
                    drustvoTA       .Update(ds.Drustvo);
                    MessageBox      .Show("Zapis je uspješno uvezen");
                    ds              .AcceptChanges();

                    this            .Close();
                }

                if (dgvUvoz.DataSource == ds.Mjesto)
                {
                    mjestoTA        .Update(ds.Mjesto);
                    MessageBox      .Show("Zapis je uspješno uvezen");
                    ds              .AcceptChanges();

                    this            .Close();
                }

                if (dgvUvoz.DataSource == ds.Drzava)
                {
                    drzavaTA        .Update(ds.Drzava);
                    MessageBox      .Show("Zapis je uspješno uvezen");
                    ds              .AcceptChanges();

                    this            .Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox          .Show(ex.Message);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
