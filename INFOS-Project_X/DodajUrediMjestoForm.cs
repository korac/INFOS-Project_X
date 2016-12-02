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
    public partial class DodajUrediMjestoForm : Form
    {

        infosXDatabaseDataSet ds                                            = new infosXDatabaseDataSet();
        infosXDatabaseDataSetTableAdapters.DrzavaTableAdapter drzavaTA      = new infosXDatabaseDataSetTableAdapters.DrzavaTableAdapter();
        public infosXDatabaseDataSet.MjestoRow MjestoRow { get; set; }
        private bool _isUredi;
        
        public DodajUrediMjestoForm(infosXDatabaseDataSet.MjestoRow mjestoRow, bool isUredi)
        {
            InitializeComponent();
            _isUredi                                    = isUredi;
            MjestoRow                                   = mjestoRow;

            drzavaTA.Connection.ConnectionString        = PomocneFunkcije.connectionString;

        }

        private void DodajUrediMjestoForm_Load(object sender, EventArgs e)
        {
            drzavaTA.Fill(ds.Drzava);

            if(_isUredi)
            {
                this.Text                   = "Uredi mjesto";

                tboxMjestoID.Text           = MjestoRow.ID;
                tboxIme.Text                = MjestoRow.Ime;

                cboxDrzava.DataSource       = ds.Drzava;
                cboxDrzava.DisplayMember    = "Ime";
                cboxDrzava.ValueMember      = "ID";
                cboxDrzava.SelectedValue    = MjestoRow.Drzava_ID;
            }
            else
            {
                this.Text                   = "Dodaj mjesto";

                cboxDrzava.DataSource       = ds.Drzava;
                cboxDrzava.DisplayMember    = "Ime";
                cboxDrzava.ValueMember      = "ID";
            }
        }

        private void btnPrihvati_Click(object sender, EventArgs e)
        {
            if (ValidateID())
            {
                if(ValidateIme())
                {
                    MjestoRow.ID                = tboxMjestoID.Text;
                    MjestoRow.Ime               = tboxIme.Text;
                    MjestoRow.Drzava_ID         = cboxDrzava.SelectedValue.ToString();

                    this.DialogResult           = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Unesite sve potrebne podatke");
                }
            }
        }

        private void RefreshComboDrzava()
        {
            ds.Drzava.Clear();
            drzavaTA.Fill(ds.Drzava);
            
            cboxDrzava.DataSource           = ds.Drzava;
            cboxDrzava.DisplayMember        = "Ime";
            cboxDrzava.ValueMember          = "ID";
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOdaberiDrzavu_Click(object sender, EventArgs e)
        {
            Form2 odaberiDrzavu                     = new Form2(MaticniPodaci.Drzave, true);
            odaberiDrzavu.Text                      = "Odaberi državu";
            odaberiDrzavu.WindowState               = FormWindowState.Normal;
            if(odaberiDrzavu.ShowDialog() == DialogResult.OK)
            {
                RefreshComboDrzava();
                cboxDrzava.SelectedValue            = odaberiDrzavu.DrzavaRow.ID;
            }
        }

        private void tboxMjestoID_Validating(object sender, CancelEventArgs e)
        {
            ValidateID();
        }

        private void tboxIme_Validating(object sender, CancelEventArgs e)
        {
            ValidateIme();
        }

        private bool ValidateID()
        {
            bool bStatus                = true;
            if(tboxMjestoID.Text == "")
            {
                errProviderID           .SetError(tboxMjestoID, "Unesite ID mjesta");
                bStatus                 = false;
            }
            else if (!PomocneFunkcije.IDExists(tboxMjestoID.Text, MaticniPodaci.Mjesta))
            {
                MessageBox              .Show("Unijeli ste već postojeći ID");
                errProviderID           .SetError(tboxMjestoID, "Unesite jedinstveni ID mjesta");
                bStatus                 = false;
            }
            else
            {
                errProviderID           .SetError(tboxMjestoID, "");
            }

            return bStatus;
        }

        private bool ValidateIme()
        {
            bool bStatus                = true;
            if(tboxIme.Text == "")
            {
                errProviderIme          .SetError(tboxIme, "Unesite ime mjesta");
                bStatus                 = false;
            }
            else if (!PomocneFunkcije.IsValidNaziv(tboxIme.Text))
            {
                errProviderIme          .SetError(tboxIme, "Unesite ispravano ime mjesta");
                bStatus                 = false;
            }
            else
            {
                errProviderIme          .SetError(tboxIme, ""); 
            }

            return bStatus;
        }


    }
}
