using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace INFOS_Project_X
{
    public partial class IzlazUpozorenjeForm : Form
    {
        public IzlazUpozorenjeForm()
        {
            InitializeComponent();
        }

        private void btnIzadi_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
