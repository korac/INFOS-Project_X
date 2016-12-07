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
    public partial class DodajUrediDrzavaForm : Form
    {
        public infosXDatabaseDataSet.DrzavaRow DrzavaRow { get; set; }
        private bool _isUredi;
        public DodajUrediDrzavaForm(infosXDatabaseDataSet.DrzavaRow drzavaRow, bool isUredi)
        {
            InitializeComponent();
            _isUredi                    = isUredi;
            DrzavaRow                   = drzavaRow;
        }

        private void DodajUrediDrzavaForm_Load(object sender, EventArgs e)
        {
            if(_isUredi)
            {
                this.Text               = "Uredi državu";

                tboxDrzavaID.Enabled    = false;

                tboxDrzavaID.Text       = DrzavaRow.ID;
                tboxIme.Text            = DrzavaRow.Ime;
                tboxJezik.Text          = DrzavaRow.Jezik;
                tboxPozivni.Text        = DrzavaRow.PozivniBroj;
                tboxValuta.Text         = DrzavaRow.Valuta;
            }
            else
            {
                this.Text               = "Dodaj državu";
            }
        }

        private void btnPrihvati_Click(object sender, EventArgs e)
        {
            if (ValidateID())
            {
                if(ValidateIme() && ValidateJezik() && ValidatePozivni() && ValidateValuta())
                {
                    DrzavaRow.ID                = tboxDrzavaID.Text;
                    DrzavaRow.Ime               = tboxIme.Text;
                    DrzavaRow.Jezik             = tboxJezik.Text;
                    DrzavaRow.PozivniBroj       = tboxPozivni.Text;
                    DrzavaRow.Valuta            = tboxValuta.Text;

                    this.DialogResult           = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Molimo unesite sve potrebne podatke");
                }
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tboxDrzavaID_Validating(object sender, CancelEventArgs e)
        {
            ValidateID();
        }

        private void tboxIme_Validating(object sender, CancelEventArgs e)
        {
            ValidateIme();
        }

        private void tboxJezik_Validating(object sender, CancelEventArgs e)
        {
            ValidateJezik();
        }

        private void tboxPozivni_Validating(object sender, CancelEventArgs e)
        {
            ValidatePozivni();
        }

        private void tboxValuta_Validating(object sender, CancelEventArgs e)
        {
            ValidateValuta();
        }

        private bool ValidateID()
        {
            bool bStatus                = true;
            if(tboxDrzavaID.Text == "")
            {
                errProviderID           .SetError(tboxDrzavaID, "Unesite ID države");
                bStatus                 = false;
            }
            else if (!_isUredi && !PomocneFunkcije.IDExists(tboxDrzavaID.Text, MaticniPodaci.Drzave))
            {
                MessageBox              .Show("Unijeli ste već postojeći ID");
                errProviderID           .SetError(tboxDrzavaID, "Unesite jedinstveni ID države");
                bStatus                 = false;
            }
            else
            {
                errProviderID           .SetError(tboxDrzavaID, "");
            }

            return bStatus;
        }

        private bool ValidateIme()
        {
            bool bStatus                = true;
            if(tboxIme.Text == "")
            {
                errProviderIme          .SetError(tboxIme, "Unesite ime države");
                bStatus                 = false;
            }
            else if (!PomocneFunkcije.IsValidNaziv(tboxIme.Text))
            {
                errProviderIme          .SetError(tboxIme, "Unesite ispravano ime države");
                bStatus                 = false;
            }
            else
            {
                errProviderIme          .SetError(tboxIme, ""); 
            }

            return bStatus;
        }

        private bool ValidateJezik()
        {
            bool bStatus                = true;
            if(tboxJezik.Text == "")
            {
                errProviderJezik        .SetError(tboxJezik, "Unesite jezik");
                bStatus                 = false;
            }
            else if (!PomocneFunkcije.IsValidNaziv(tboxJezik.Text))
            {
                errProviderJezik        .SetError(tboxJezik, "Unesite ispravan jezik");
                bStatus                 = false;
            }
            else
            {
                errProviderJezik        .SetError(tboxJezik, ""); 
            }

            return bStatus;
        }

        private bool ValidatePozivni()
        {
            bool bStatus                = true;
            if(tboxPozivni.Text == "")
            {
                errProviderPozivni      .SetError(tboxPozivni, "Unesite pozivni broj");
                bStatus                 = false;
            }
            else if (!PomocneFunkcije.isValidPozivni(tboxPozivni.Text))
            {
                errProviderPozivni      .SetError(tboxPozivni, "Unesite ispravan pozivni broj");
                bStatus                 = false;
            }
            else
            {
                errProviderPozivni      .SetError(tboxPozivni, ""); 
            }

            return bStatus;
        }

        private bool ValidateValuta()
        {
            bool bStatus                = true;
            if(tboxValuta.Text == "")
            {
                errProviderValuta       .SetError(tboxValuta, "Unesite valutu");
                bStatus                 = false;
            }
            else if (!PomocneFunkcije.IsValidNaziv(tboxValuta.Text))
            {
                errProviderValuta       .SetError(tboxValuta, "Unesite ispravno ime valute");
                bStatus                 = false;
            }
            else
            {
                errProviderValuta       .SetError(tboxValuta, ""); 
            }

            return bStatus;
        }

    }
}
