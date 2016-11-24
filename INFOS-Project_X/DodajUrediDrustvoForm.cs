using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFOS_Project_X
{
    public partial class DodajUrediDrustvoForm : Form
    {
        infosXDatabaseDataSet ds                                            = new infosXDatabaseDataSet();
        infosXDatabaseDataSetTableAdapters.MjestoTableAdapter mjestoTA      = new infosXDatabaseDataSetTableAdapters.MjestoTableAdapter();
        public infosXDatabaseDataSet.DrustvoRow DrustvoRow { get; set; }
        private bool _isUredi;

        public DodajUrediDrustvoForm(infosXDatabaseDataSet.DrustvoRow drustvoRow, bool isUredi)
        {
            InitializeComponent();
            _isUredi                                    = isUredi;
            DrustvoRow                                  = drustvoRow;

            mjestoTA.Connection.ConnectionString        = PomocneFunkcije.connectionString;
        }

        private void DodajUrediDrustvoForm_Load(object sender, EventArgs e)
        {
            mjestoTA.Fill(ds.Mjesto);

            if(_isUredi)
            {
                this.Text                   = "Uredi društvo";

                tboxNaziv.Text              = DrustvoRow.Naziv;
                tboxAdresa.Text             = DrustvoRow.IsAdresaNull() ? "" : DrustvoRow.Adresa;
                tboxEmail.Text              = DrustvoRow.IsEmailNull() ? "" : DrustvoRow.Email;
                tboxTelefon.Text            = DrustvoRow.IsTelefonNull() ? "" : DrustvoRow.Telefon.ToString();
                tboxBrojRacuna.Text         = DrustvoRow.IsBrojRacunaNull() ? "" : DrustvoRow.BrojRacuna.ToString();

                cboxMjesto.DataSource       = ds.Mjesto;
                cboxMjesto.DisplayMember    = "Ime";
                cboxMjesto.ValueMember      = "ID";
                cboxMjesto.SelectedValue    = DrustvoRow.Mjesto_ID;
            }
            else
            {
                this.Text                   = "Dodaj društvo";

                cboxMjesto.DataSource       = ds.Mjesto;
                cboxMjesto.DisplayMember    = "Ime";
                cboxMjesto.ValueMember      = "ID";
            }
        }

        private void btnPrihvati_Click(object sender, EventArgs e)
        {            
            if(ValidateNaziv() && ValidateAdresa() && ValidateTelefon() && ValidateBrojRacuna())
            {
                DrustvoRow.Naziv            = tboxNaziv.Text;
                DrustvoRow.Adresa           = tboxAdresa.Text;
                DrustvoRow.Email            = tboxEmail.Text;
                DrustvoRow.Telefon          = tboxTelefon.Text;
                DrustvoRow.Mjesto_ID        = (int) cboxMjesto.SelectedValue;
                DrustvoRow.BrojRacuna       = tboxBrojRacuna.Text;

                this.DialogResult           = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Molimo unesite sve potrebne podatke");
            }
            
        }

        private void RefreshComboMjesta()
        {
            ds.Mjesto.Clear();
            mjestoTA.Fill(ds.Mjesto);

            cboxMjesto.DataSource           = ds.Mjesto;
            cboxMjesto.DisplayMember        = "Ime";
            cboxMjesto.ValueMember          = "ID";
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOdaberiMjesta_Click(object sender, EventArgs e)
        {
            Form2 odaberiMjesto                 = new Form2(MaticniPodaci.Mjesta, true);

            odaberiMjesto.Text                  = "Odaberi mjesto";
            odaberiMjesto.WindowState           = FormWindowState.Normal;            
            if(odaberiMjesto.ShowDialog() == DialogResult.OK)
            {
                RefreshComboMjesta();
                cboxMjesto.SelectedValue        = odaberiMjesto.MjestoRow.ID;
            }            
        }

        private void tboxNaziv_Validating(object sender, CancelEventArgs e)
        {
            ValidateNaziv();
        }

        private void tboxAdresa_Validating(object sender, CancelEventArgs e)
        {
            ValidateAdresa();
        }


        private void tboxTelefon_Validating(object sender, CancelEventArgs e)
        {
            ValidateTelefon();
        }

        private void tboxBrojRacuna_Validating(object sender, CancelEventArgs e)
        {
            ValidateBrojRacuna();
        }

        private bool ValidateNaziv()
        {
            bool bStatus                = true;
            if(tboxNaziv.Text == "")
            {
                errProviderNaziv        .SetError(tboxNaziv, "Molimo unesite naziv društva");
                bStatus                 = false;
            }
            else if (!PomocneFunkcije.IsValidNaziv(tboxNaziv.Text))
            {
                errProviderNaziv        .SetError(tboxNaziv, "Molimo unesite ispravan naziv društva");
                bStatus                 = false;
            }
            else
            {
                errProviderNaziv        .SetError(tboxNaziv, ""); 
            }

            return bStatus;
        }

        private bool ValidateAdresa()
        {
            bool bStatus = true;
            if(!PomocneFunkcije.isValidAdresa(tboxAdresa.Text))
            {
                errProviderAdresa       .SetError(tboxAdresa, "Molimo unesite ispravnu adresu");
                bStatus                 = false;
            }
            else
            {
                errProviderAdresa       .SetError(tboxAdresa, "");
            }

            return bStatus;
        }

        private bool ValidateTelefon()
        {
            bool bStatus                = true;
            if (!PomocneFunkcije.isValidTelefon(tboxTelefon.Text))
            {
                errProviderTelefon      .SetError(tboxTelefon, "Molimo unesite ispravan broj telefona");
                bStatus                 = false;
            }
            else
            {
                errProviderTelefon      .SetError(tboxTelefon, "");
            }

            return bStatus;
        }

        private bool ValidateBrojRacuna()
        {
            bool bStatus                = true;
            if (!PomocneFunkcije.isValidBrojRacuna(tboxBrojRacuna.Text))
            {
                errProviderBrojRacuna   .SetError(tboxBrojRacuna, "Molimo unesite ispravan broj računa");
                bStatus                 = false;
            }
            else
            {
                errProviderBrojRacuna   .SetError(tboxBrojRacuna, "");
            }

            return bStatus;
        }

    }
}
