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
    public partial class DodajUrediClanForm : Form
    {
        infosXDatabaseDataSet ds                                                = new infosXDatabaseDataSet();
        infosXDatabaseDataSetTableAdapters.DrustvoTableAdapter drustvoTA        = new infosXDatabaseDataSetTableAdapters.DrustvoTableAdapter();
        infosXDatabaseDataSetTableAdapters.MjestoTableAdapter mjestoTA          = new infosXDatabaseDataSetTableAdapters.MjestoTableAdapter();

        public infosXDatabaseDataSet.ClanRow ClanRow { get; set; }
        private bool _isUredi;
        public DodajUrediClanForm(infosXDatabaseDataSet.ClanRow clanRow, bool isUredi)
        {
            InitializeComponent();
            _isUredi                                    = isUredi;
            ClanRow                                     = clanRow;

            drustvoTA.Connection.ConnectionString       = PomocneFunkcije.connectionString;
            mjestoTA.Connection.ConnectionString        = PomocneFunkcije.connectionString;
        }

        private void DodajUrediClanForm_Load(object sender, EventArgs e)
        {
            drustvoTA   .Fill(ds.Drustvo);
            mjestoTA    .Fill(ds.Mjesto);

            if(_isUredi)
            {
                this.Text                   = "Uredi člana";

                tboxIme.Text                = ClanRow.Ime;
                tboxPrezime.Text            = ClanRow.Prezime;
                tboxOib.Text                = ClanRow.OIB;
                tboxDatumRodenja.Text       = ClanRow.DatumRodenja.ToShortDateString();

                // Provjerava jesu li vrijednosti iz baze NULL; ako da, stavlja prazan string u textBox
                tboxZanimanje.Text          = ClanRow.IsZanimanjeNull() ? "" : ClanRow.Zanimanje;
                tboxTelefon.Text            = ClanRow.IsTelefonNull() ? "" : ClanRow.Telefon;
                tboxEmail.Text              = ClanRow.IsEmailNull() ? "" : ClanRow.Email;
                tboxAdresa.Text             = ClanRow.IsAdresaNull() ? "" : ClanRow.Adresa;

                cboxDrustvo.DataSource      = ds.Drustvo;
                cboxDrustvo.DisplayMember   = "Naziv";
                cboxDrustvo.ValueMember     = "ID";
                cboxDrustvo.SelectedValue   = ClanRow.Drustvo_ID;

                cboxMjesto.DataSource       = ds.Mjesto;
                cboxMjesto.DisplayMember    = "Ime";
                cboxMjesto.ValueMember      = "ID";

                if(ClanRow["Mjesto_ID"] != DBNull.Value)
                {
                    cboxMjesto.SelectedValue = ClanRow.Mjesto_ID;
                }                
            }
            else
            {
                this.Text                   = "Dodaj novog člana";

                cboxDrustvo.DataSource      = ds.Drustvo;
                cboxDrustvo.DisplayMember   = "Naziv";
                cboxDrustvo.ValueMember     = "ID";

                cboxMjesto.DataSource       = ds.Mjesto;
                cboxMjesto.DisplayMember    = "Ime";
                cboxMjesto.ValueMember      = "ID";
            }
        }

        private void btnPrihvati_Click(object sender, EventArgs e)
        {
            if (ValidateIme("ime") && ValidateIme("prezime") && ValidateOIB() && ValidateDatumRodenja() && ValidateZanimanje() && ValidateAdresa() && ValidateTelefon())
            {
                ClanRow.Ime                     = tboxIme.Text;
                ClanRow.Prezime                 = tboxPrezime.Text;
                ClanRow.OIB                     = tboxOib.Text;
                ClanRow.DatumRodenja            = Convert.ToDateTime(tboxDatumRodenja.Text);
                ClanRow.Zanimanje               = tboxZanimanje.Text;
                ClanRow.Drustvo_ID              = cboxDrustvo.SelectedValue.ToString();
                ClanRow.Mjesto_ID               = cboxMjesto.SelectedValue.ToString();
                ClanRow.Telefon                 = tboxTelefon.Text;
                ClanRow.Email                   = tboxEmail.Text;
                ClanRow.Adresa                  = tboxAdresa.Text;

                this.DialogResult               = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Molimo unesite sve potrebne podatke");
            }
            
        }

        private void RefreshComboDrustvo()
        {
            ds.Drustvo.Clear();
            drustvoTA.Fill(ds.Drustvo);

            cboxDrustvo.DataSource      = ds.Drustvo;
            cboxDrustvo.DisplayMember   = "Naziv";
            cboxDrustvo.ValueMember     = "ID";
        }

        private void RefreshComboMjesto()
        {
            ds.Mjesto.Clear();
            mjestoTA.Fill(ds.Mjesto);

            cboxMjesto.DataSource       = ds.Mjesto;
            cboxMjesto.DisplayMember    = "Ime";
            cboxMjesto.ValueMember      = "ID";
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tboxIme_Validating(object sender, CancelEventArgs e)
        {
            ValidateIme("ime");
        }

        private void tboxPrezime_Validating(object sender, CancelEventArgs e)
        {
            ValidateIme("prezime");
        }


        private void tboxOib_Validating(object sender, CancelEventArgs e)
        {
            ValidateOIB();
        }


        private void tboxDatumRodenja_Validating(object sender, CancelEventArgs e)
        {
            ValidateDatumRodenja();
        }

        private void tboxZanimanje_Validating(object sender, CancelEventArgs e)
        {
            ValidateZanimanje();
        }

        private void tboxTelefon_Validating(object sender, CancelEventArgs e)
        {
            ValidateTelefon();
        }

        private void tboxAdresa_Validating(object sender, CancelEventArgs e)
        {
            ValidateAdresa();
        }

        private bool ValidateIme(string name)
        {
            bool bStatus                = true;
            TextBox box                 = (name == "ime") ? tboxIme : tboxPrezime;
            ErrorProvider errProvider   = (name == "ime") ? errProviderIme : errProviderPrezime;

            if(box.Text == "")
            {
                errProvider             .SetError(box, "Molimo unesite " + name + " člana");
                bStatus                 = false;
            }
            else if (!PomocneFunkcije.IsValidIme(box.Text))
            {
                errProvider             .SetError(box, "Molimo unesite ispravano " + name);
                bStatus                 = false;
            }
            else
            {
                errProvider             .SetError(box, "");
            }

            return bStatus;
        }

        private bool ValidateOIB()
        {
            bool bStatus                = true;
            if (tboxOib.Text == "")
            {
                errProviderOIB          .SetError(tboxOib, "Molimo unesite OIB člana");
                bStatus                 = false;
            }
            else if(!PomocneFunkcije.isValidOIB(tboxOib.Text))
            {
                errProviderOIB          .SetError(tboxOib, "Molimo unesite ispravan OIB člana");
                bStatus                 = false;
            }
            else
            {
                errProviderOIB          .SetError(tboxOib, "");
            }

            return bStatus;
        }

        private bool ValidateDatumRodenja()
        {
            bool bStatus                = true;
            if (tboxDatumRodenja.Text == "")
            {
                errProviderDatumRodenja .SetError(tboxDatumRodenja, "Molimo unesite datum rođenja člana");
                bStatus                 = false;
            }
            else if(!PomocneFunkcije.isValidDatumRodenja(tboxDatumRodenja.Text))
            {
                errProviderDatumRodenja .SetError(tboxDatumRodenja, "Molimo unesite ispravan datum rođenja člana");
                bStatus                 = false;
            }
            else
            {
                errProviderDatumRodenja .SetError(tboxDatumRodenja, "");
            }

            return bStatus;
        }

        private bool ValidateZanimanje()
        {
            bool bStatus                = true;
            if (!PomocneFunkcije.IsValidIme(tboxZanimanje.Text))
            {
                errProviderZanimanje    .SetError(tboxZanimanje, "Molimo unesite ispravan naziv zanimanja");
                bStatus                 = false;
            }
            else
            {
                errProviderZanimanje    .SetError(tboxZanimanje, "");
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

        private bool ValidateAdresa()
        {
            bool bStatus                = true;
            if (!PomocneFunkcije.isValidAdresa(tboxAdresa.Text))
            {
                errProviderAdresa       .SetError(tboxAdresa, "Molimo unesite ispravanu adresu");
                bStatus                 = false;
            }
            else
            {
                errProviderAdresa       .SetError(tboxAdresa, "");
            }

            return bStatus;
        }

        private void btnOdaberiMjesta_Click(object sender, EventArgs e)
        {
            Form2 odaberiMjesto         = new Form2(MaticniPodaci.Mjesta, true);

            odaberiMjesto.Text          = "Odaberi mjesto";
            odaberiMjesto.WindowState   = FormWindowState.Normal;            
            if(odaberiMjesto.ShowDialog() == DialogResult.OK)
            {
                RefreshComboMjesto();
                cboxMjesto.SelectedValue    = odaberiMjesto.MjestoRow.ID;
            }    
        }

        private void btnOdaberiDrustvo_Click(object sender, EventArgs e)
        {
            Form2 odaberiDrustvo            = new Form2(MaticniPodaci.Drustva, true);

            odaberiDrustvo.Text             = "Odaberi društvo";
            odaberiDrustvo.WindowState      = FormWindowState.Normal;            
            if(odaberiDrustvo.ShowDialog() == DialogResult.OK)
            {
                RefreshComboDrustvo();
                cboxDrustvo.SelectedValue   = odaberiDrustvo.DrustvoRow.ID;
            }  
        }

    }
}
