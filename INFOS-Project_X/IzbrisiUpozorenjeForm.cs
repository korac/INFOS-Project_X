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
    public partial class IzbrisiUpozorenjeForm : Form
    {
        public bool _izbrisi;
        public IzbrisiUpozorenjeForm()
        {
            InitializeComponent();
            this.Text           = "Brisanje";
            lblPoruka.Text      = "Jeste li sigurni da želite ovo izbrisati?";
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            _izbrisi            = true;

            this.DialogResult   = DialogResult.OK;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
