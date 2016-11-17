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
            DrzavaRow.Ime               = tboxIme.Text;
            DrzavaRow.Jezik             = tboxJezik.Text;
            DrzavaRow.PozivniBroj       = tboxPozivni.Text;
            DrzavaRow.Valuta            = tboxValuta.Text;

            this.DialogResult           = DialogResult.OK;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
