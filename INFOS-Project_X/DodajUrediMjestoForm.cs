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
            _isUredi                    = isUredi;
            MjestoRow                   = mjestoRow;

        }

        private void DodajUrediMjestoForm_Load(object sender, EventArgs e)
        {
            drzavaTA.Fill(ds.Drzava);

            if(_isUredi)
            {
                this.Text                   = "Uredi mjesto";

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
            MjestoRow.Ime = tboxIme.Text;
            MjestoRow.Drzava_ID = (int) cboxDrzava.SelectedValue;

            this.DialogResult = DialogResult.OK;
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
                cboxDrzava.Text                     = odaberiDrzavu.DrzavaRow.Ime;
                MjestoRow.Drzava_ID                 = odaberiDrzavu.DrzavaRow.ID;
            }
        }

        
    }
}
