using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFOS_Project_X
{
    public partial class Form2 : Form
    {
        infosXDatabaseDataSet ds                                            = new infosXDatabaseDataSet();
        infosXDatabaseDataSetTableAdapters.DrustvoTableAdapter drustvoTA    = new infosXDatabaseDataSetTableAdapters.DrustvoTableAdapter();
        infosXDatabaseDataSetTableAdapters.MjestoTableAdapter mjestoTA      = new infosXDatabaseDataSetTableAdapters.MjestoTableAdapter();
        infosXDatabaseDataSetTableAdapters.DrzavaTableAdapter drzavaTA      = new infosXDatabaseDataSetTableAdapters.DrzavaTableAdapter();
        infosXDatabaseDataSetTableAdapters.ClanTableAdapter clanTA          = new infosXDatabaseDataSetTableAdapters.ClanTableAdapter();

        BindingSource drustvoBS = new BindingSource();
        BindingSource mjestoBS  = new BindingSource();
        BindingSource drzavaBS  = new BindingSource();
        BindingSource clanBS    = new BindingSource();

        MaticniPodaci _maticniPodaci;

        public infosXDatabaseDataSet.MjestoRow MjestoRow { get; set; }
        public infosXDatabaseDataSet.DrzavaRow DrzavaRow { get; set; }
        public infosXDatabaseDataSet.DrustvoRow DrustvoRow { get; set; }

        public Form2(MaticniPodaci maticniPodaci, bool odaberi)
        {
            InitializeComponent();
            _maticniPodaci                              = maticniPodaci;

            btnOdaberi.Visible                          = odaberi;
            btnOdustani.Visible                         = odaberi;

            clanTA.Connection.ConnectionString          = PomocneFunkcije.connectionString;
            drustvoTA.Connection.ConnectionString       = PomocneFunkcije.connectionString;
            mjestoTA.Connection.ConnectionString        = PomocneFunkcije.connectionString;
            drzavaTA.Connection.ConnectionString        = PomocneFunkcije.connectionString;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            Console.WriteLine(PomocneFunkcije.connectionString);
            dgvPrikaz.AutoGenerateColumns                   = false;

            switch (_maticniPodaci)
            {
                case MaticniPodaci.Clan:

                    DataGridViewTextBoxColumn dgcIme        = new DataGridViewTextBoxColumn();
                    dgcIme.HeaderText                       = "Ime";
                    dgcIme.DataPropertyName                 = "Ime";
                    dgcIme.ToolTipText                      = "Ime člana";

                    DataGridViewTextBoxColumn dgcPrezime    = new DataGridViewTextBoxColumn();
                    dgcPrezime.HeaderText                   = "Prezime";
                    dgcPrezime.DataPropertyName             = "Prezime";
                    dgcPrezime.ToolTipText                  = "Prezme člana";

                    DataGridViewTextBoxColumn dgcOib        = new DataGridViewTextBoxColumn();
                    dgcOib.HeaderText                       = "OIB";
                    dgcOib.DataPropertyName                 = "OIB";
                    dgcOib.ToolTipText                      = "OIB člana";

                    DataGridViewTextBoxColumn dgcDrustvo    = new DataGridViewTextBoxColumn();
                    dgcDrustvo.HeaderText                   = "Društvo";
                    dgcDrustvo.DataPropertyName             = "DrustvoExp";
                    dgcDrustvo.ToolTipText                  = "Društvo člana";

                    dgvPrikaz.Columns.Add(dgcIme);
                    dgvPrikaz.Columns.Add(dgcPrezime);
                    dgvPrikaz.Columns.Add(dgcOib);
                    dgvPrikaz.Columns.Add(dgcDrustvo);

                    //Custom funkcija za resizanje stupaca u DataGridView
                    AutoSizeDgvColumns(dgvPrikaz.Columns);

                    this.Cursor                             = Cursors.WaitCursor;
                    drustvoTA.Fill(ds.Drustvo);

                    clanTA.Fill(ds.Clan);
                    clanBS.DataSource                       = ds.Clan;
                    dgvPrikaz.DataSource                    = clanBS;
                    this.Cursor                             = Cursors.Default;

                    txtBoxName.DataBindings.Add(new Binding("Text", clanBS, "Ime"));

                    lblPrikaz.Text                          = "Članovi";
                    btnDodaj.Text                           = "Dodaj člana";
                    break;

                case MaticniPodaci.Drustva:

                    DataGridViewTextBoxColumn dgcNaziv      = new DataGridViewTextBoxColumn();
                    dgcNaziv.HeaderText                     = "Naziv";
                    dgcNaziv.DataPropertyName               = "Naziv";
                    dgcNaziv.ToolTipText                    = "Naziv društva";

                    DataGridViewTextBoxColumn dgcEmail      = new DataGridViewTextBoxColumn();
                    dgcEmail.HeaderText                     = "Email";
                    dgcEmail.DataPropertyName               = "Email";
                    dgcEmail.ToolTipText                    = "Email društva";

                    DataGridViewTextBoxColumn dgcAdresa     = new DataGridViewTextBoxColumn();
                    dgcAdresa.HeaderText                    = "Adresa";
                    dgcAdresa.DataPropertyName              = "Adresa";
                    dgcAdresa.ToolTipText                   = "Adresa društva";

                    DataGridViewTextBoxColumn dgcMjesto     = new DataGridViewTextBoxColumn();
                    dgcMjesto.HeaderText                    = "Mjesto";
                    dgcMjesto.DataPropertyName              = "MjestoExp";
                    dgcMjesto.ToolTipText                   = "Mjesto društva";
                    
                    dgvPrikaz.Columns.Add(dgcNaziv);
                    dgvPrikaz.Columns.Add(dgcEmail);
                    dgvPrikaz.Columns.Add(dgcAdresa);
                    dgvPrikaz.Columns.Add(dgcMjesto);

                    AutoSizeDgvColumns(dgvPrikaz.Columns);

                    this.Cursor                             = Cursors.WaitCursor;
                    mjestoTA.Fill(ds.Mjesto);

                    drustvoTA.Fill(ds.Drustvo);
                    drustvoBS.DataSource                    = ds.Drustvo;
                    dgvPrikaz.DataSource                    = drustvoBS;
                    this.Cursor                             = Cursors.Default;

                    txtBoxName.DataBindings.Add(new Binding("Text", drustvoBS, "Naziv"));

                    lblPrikaz.Text                          = "Društva";
                    btnDodaj.Text                           = "Dodaj društvo";
                    break;

                case MaticniPodaci.Mjesta:

                    DataGridViewTextBoxColumn dgcImeMjesta  = new DataGridViewTextBoxColumn();
                    dgcImeMjesta.HeaderText                 = "Ime";
                    dgcImeMjesta.DataPropertyName           = "Ime";
                    dgcImeMjesta.ToolTipText                = "Ime mjesta";

                    DataGridViewTextBoxColumn dgcDrzava     = new DataGridViewTextBoxColumn();
                    dgcDrzava.HeaderText                    = "Država";
                    dgcDrzava.DataPropertyName              = "DrzavaExp";
                    dgcDrzava.ToolTipText                   = "Država mjesta";

                    dgvPrikaz.Columns.Add(dgcImeMjesta);
                    dgvPrikaz.Columns.Add(dgcDrzava);

                    AutoSizeDgvColumns(dgvPrikaz.Columns);

                    this.Cursor                             = Cursors.WaitCursor;
                    drzavaTA.Fill(ds.Drzava);

                    mjestoTA.Fill(ds.Mjesto);
                    mjestoBS.DataSource                     = ds.Mjesto;
                    dgvPrikaz.DataSource                    = mjestoBS;
                    this.Cursor                             = Cursors.Default;

                    txtBoxName.DataBindings.Add(new Binding("Text", mjestoBS, "Ime"));

                    lblPrikaz.Text                          = "Mjesta";
                    btnDodaj.Text                           = "Dodaj mjesto";
                    break;

                case MaticniPodaci.Drzave:

                    DataGridViewTextBoxColumn dgcImeDrzave      = new DataGridViewTextBoxColumn();
                    dgcImeDrzave.HeaderText                     = "Ime";
                    dgcImeDrzave.DataPropertyName               = "Ime";
                    dgcImeDrzave.ToolTipText                    = "Ime mjesta";

                    DataGridViewTextBoxColumn dgcPozivniBroj    = new DataGridViewTextBoxColumn();
                    dgcPozivniBroj.HeaderText                   = "Pozivni broj";
                    dgcPozivniBroj.DataPropertyName             = "PozivniBroj";
                    dgcPozivniBroj.ToolTipText                  = "Pozivni broj države";

                    DataGridViewTextBoxColumn dgcValuta         = new DataGridViewTextBoxColumn();
                    dgcValuta.HeaderText                        = "Valuta države";
                    dgcValuta.DataPropertyName                  = "Valuta";
                    dgcValuta.ToolTipText                       = "Valuta države";

                    dgvPrikaz.Columns.Add(dgcImeDrzave);
                    dgvPrikaz.Columns.Add(dgcPozivniBroj);
                    dgvPrikaz.Columns.Add(dgcValuta);

                    AutoSizeDgvColumns(dgvPrikaz.Columns);

                    this.Cursor                                 = Cursors.WaitCursor;
                    drzavaTA.Fill(ds.Drzava);
                    drzavaBS.DataSource                         = ds.Drzava;
                    dgvPrikaz.DataSource                        = drzavaBS;
                    this.Cursor                                 = Cursors.Default;

                    txtBoxName.DataBindings.Add(new Binding("Text", drzavaBS, "Ime"));

                    lblPrikaz.Text                              = "Države";
                    btnDodaj.Text                               = "Dodaj državu";
                    break;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            switch (_maticniPodaci)
            {
                case MaticniPodaci.Clan:

                    infosXDatabaseDataSet.ClanRow newClanRow            = ds.Clan.NewClanRow();
                    DodajUrediClanForm dodajClanForm                    = new DodajUrediClanForm(newClanRow, false);
                    if(dodajClanForm.ShowDialog() == DialogResult.OK)
                    {
                        ds.Clan             .AddClanRow(dodajClanForm.ClanRow);
                        clanTA              .Update(ds.Clan);
                        MessageBox          .Show("Zapis je uspješno spremljen");
                        ds                  .AcceptChanges();
                    }
                    else
                    {
                        ds                  .RejectChanges();
                    }
                    break;
                case MaticniPodaci.Drustva:

                    infosXDatabaseDataSet.DrustvoRow newDrustvoRow      = ds.Drustvo.NewDrustvoRow();
                    DodajUrediDrustvoForm dodajDrustvoForm              = new DodajUrediDrustvoForm(newDrustvoRow, false);
                    if (dodajDrustvoForm.ShowDialog() == DialogResult.OK)
                    {
                        ds.Drustvo          .AddDrustvoRow(dodajDrustvoForm.DrustvoRow);
                        drustvoTA           .Update(ds.Drustvo);
                        MessageBox          .Show("Zapis je uspješno spremljen!");
                        ds                  .AcceptChanges();
                    }
                    else
                    {
                        ds.Drustvo          .RejectChanges();
                    }

                    break;

                case MaticniPodaci.Mjesta:

                    infosXDatabaseDataSet.MjestoRow newMjestoRow        = ds.Mjesto.NewMjestoRow();
                    DodajUrediMjestoForm dodajMjestoForm                = new DodajUrediMjestoForm(newMjestoRow, false);
                    if(dodajMjestoForm.ShowDialog() == DialogResult.OK)
                    {
                        ds.Mjesto           .AddMjestoRow(dodajMjestoForm.MjestoRow);
                        mjestoTA            .Update(ds.Mjesto);
                        MessageBox          .Show("Zapis je uspješno spremljen!");
                        ds                  .AcceptChanges();
                    }
                    else
                    {
                        ds                  .RejectChanges();
                    }
                    break;

                case MaticniPodaci.Drzave:

                    infosXDatabaseDataSet.DrzavaRow newDrzavaRow        = ds.Drzava.NewDrzavaRow();
                    DodajUrediDrzavaForm dodajDrzavaForm                 = new DodajUrediDrzavaForm(newDrzavaRow, false);
                    if(dodajDrzavaForm.ShowDialog() == DialogResult.OK)
                    {
                        ds.Drzava           .AddDrzavaRow(dodajDrzavaForm.DrzavaRow);
                        drzavaTA            .Update(ds.Drzava);
                        MessageBox          .Show("Zapis je uspješno spremljen");
                        ds                  .AcceptChanges();
                    }
                    else
                    {
                        ds                  .RejectChanges();
                    }
                    break;
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            switch(_maticniPodaci)
            {
                case MaticniPodaci.Clan:

                    infosXDatabaseDataSet.ClanRow currentClanRow        = ((DataRowView)(clanBS.Current)).Row as infosXDatabaseDataSet.ClanRow;
                    DodajUrediClanForm urediClanForm                    = new DodajUrediClanForm(currentClanRow, true);
                    if(urediClanForm.ShowDialog() == DialogResult.OK)
                    {
                        clanTA              .Update(ds.Clan);
                        MessageBox          .Show("Zapise je uspješno ažuriran");
                        ds                  .AcceptChanges();
                    }
                    else
                    {
                        ds                  .RejectChanges();
                    }
                    break;

                case MaticniPodaci.Drustva:

                    infosXDatabaseDataSet.DrustvoRow currentDrustvoRow  = ((DataRowView)(drustvoBS.Current)).Row as infosXDatabaseDataSet.DrustvoRow;
                    DodajUrediDrustvoForm urediDrustvoForm              = new DodajUrediDrustvoForm(currentDrustvoRow, true);
                    if(urediDrustvoForm.ShowDialog() == DialogResult.OK)
                    {
                        drustvoTA            .Update(ds.Drustvo);
                        MessageBox           .Show("Zapis je uspješno ažuriran");
                        ds                   .AcceptChanges();
                    }
                    else
                    {
                        ds                   .RejectChanges();
                    }
                    break;

                case MaticniPodaci.Mjesta:

                    infosXDatabaseDataSet.MjestoRow currentMjestoRow    = ((DataRowView)(mjestoBS.Current)).Row as infosXDatabaseDataSet.MjestoRow;
                    DodajUrediMjestoForm urediMjestoForm                = new DodajUrediMjestoForm(currentMjestoRow, true);
                    if(urediMjestoForm.ShowDialog() == DialogResult.OK)
                    {
                        mjestoTA            .Update(ds.Mjesto);
                        MessageBox          .Show("Zapis je uspješno ažuriran");
                        ds                  .AcceptChanges();
                    }
                    else
                    {
                        ds                  .RejectChanges();
                    }
                    break;

                case MaticniPodaci.Drzave:

                    infosXDatabaseDataSet.DrzavaRow currentDrzavaRow    = ((DataRowView)(drzavaBS.Current)).Row as infosXDatabaseDataSet.DrzavaRow;
                    DodajUrediDrzavaForm urediDrzavaRow                 = new DodajUrediDrzavaForm(currentDrzavaRow, true);
                    if(urediDrzavaRow.ShowDialog() == DialogResult.OK)
                    {
                        drzavaTA            .Update(ds.Drzava);
                        MessageBox          .Show("Zapis je uspješno ažuriran");
                        ds                  .AcceptChanges();
                    }
                    else
                    {
                        ds                  .RejectChanges();
                    }
                    break;
            }
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            IzbrisiUpozorenjeForm izbrisiUpozorenje = new IzbrisiUpozorenjeForm();

            switch (_maticniPodaci)
            {
                case MaticniPodaci.Clan:

                    infosXDatabaseDataSet.ClanRow currentClanRow        = ((DataRowView)(clanBS.Current)).Row as infosXDatabaseDataSet.ClanRow;
                    if(izbrisiUpozorenje.ShowDialog() == DialogResult.OK)
                    {
                        currentClanRow          .Delete();
                        clanTA                  .Update(ds.Clan);
                        ds                      .AcceptChanges();
                    }
                    else
                    {
                        ds                      .RejectChanges();
                    }
                    break;
                case MaticniPodaci.Drustva:

                    infosXDatabaseDataSet.DrustvoRow currentDrustvoRow  = ((DataRowView)(drustvoBS.Current)).Row as infosXDatabaseDataSet.DrustvoRow;
                    if (izbrisiUpozorenje.ShowDialog() == DialogResult.OK)
                    {
                        currentDrustvoRow       .Delete();
                        drustvoTA               .Update(ds.Drustvo);
                        ds                      .AcceptChanges();
                    }
                    else
                    {
                        ds                      .RejectChanges();
                    }
                    break;

                case MaticniPodaci.Mjesta:

                    infosXDatabaseDataSet.MjestoRow currentMjestoRow    = ((DataRowView)(mjestoBS.Current)).Row as infosXDatabaseDataSet.MjestoRow;
                    if(izbrisiUpozorenje.ShowDialog() == DialogResult.OK)
                    {
                        currentMjestoRow        .Delete();
                        mjestoTA                .Update(ds.Mjesto);
                        ds                      .AcceptChanges();
                    }
                    else
                    {
                        ds                      .RejectChanges();
                    }
                    break;

                case MaticniPodaci.Drzave:

                    infosXDatabaseDataSet.DrzavaRow currentDrzavaRow    = ((DataRowView)(drzavaBS.Current)).Row as infosXDatabaseDataSet.DrzavaRow;
                    if(izbrisiUpozorenje.ShowDialog() == DialogResult.OK)
                    {
                        currentDrzavaRow        .Delete();
                        drzavaTA                .Update(ds.Drzava);
                        ds                      .AcceptChanges();
                    }
                    else
                    {
                        ds                      .RejectChanges();
                    }
                    break;
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            switch(_maticniPodaci)
            {
                case MaticniPodaci.Mjesta:

                    infosXDatabaseDataSet.MjestoRow currentMjestoRow    = ((DataRowView)(mjestoBS.Current)).Row as infosXDatabaseDataSet.MjestoRow;
                    MjestoRow                                           = currentMjestoRow;

                    this.DialogResult                                   = DialogResult.OK;
                    break;

                case MaticniPodaci.Drzave:

                    infosXDatabaseDataSet.DrzavaRow currentDrzavaRow    = ((DataRowView)(drzavaBS.Current)).Row as infosXDatabaseDataSet.DrzavaRow;
                    DrzavaRow                                           = currentDrzavaRow;

                    this.DialogResult                                   = DialogResult.OK;
                    break;

                case MaticniPodaci.Drustva:

                    infosXDatabaseDataSet.DrustvoRow currentDrustvoRow  = ((DataRowView)(drustvoBS.Current)).Row as infosXDatabaseDataSet.DrustvoRow;
                    DrustvoRow                                          = currentDrustvoRow;

                    this.DialogResult                                   = DialogResult.OK;
                    break;
            }
                
            
        }

        private void AutoSizeDgvColumns(DataGridViewColumnCollection dgvColumns)
        {
            for(int i = 0; i < dgvColumns.Count; i++)
            {
                if (i == dgvColumns.Count - 1)
                {
                    dgvColumns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    dgvColumns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }                
            }
        }
    }
}
