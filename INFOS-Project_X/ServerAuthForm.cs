using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Data.SqlClient;
using System.Security;

namespace INFOS_Project_X
{
    public partial class ServerAuthForm : Form
    {
        public ServerAuthForm()
        {
            InitializeComponent();

        }

        private void ServerAuthForm_Load(object sender, EventArgs e)
        {
            RegistryKey InfosKey    = Registry.CurrentUser;
            InfosKey                = InfosKey.CreateSubKey("SOFTWARE\\C#\\Infos-ProjectX");

            string server           = (string) InfosKey.GetValue("Server");
            string database         = (string) InfosKey.GetValue("Database");
            string username         = (string) InfosKey.GetValue("username");
            string password         = (string) InfosKey.GetValue("password");

            if (server == "")
            {
                InfosKey.SetValue("Server", "");
            }
            
            if (database == "")
            {
                InfosKey.SetValue("Database", "");
            }

            if (username == "")
            {
                InfosKey.SetValue("username", "");
            }

            if (password == "")
            {
                InfosKey.SetValue("password", "");
            }
            

            InfosKey.Close();

            tboxNazivServera.Text   = server;
            tboxImeBaze.Text        = database;
            tboxKorisnickoIme.Text  = username;
            tboxLozinka.Text        = password;
            
        }

        private void btnSpoji_Click(object sender, EventArgs e)
        {
            if(ValidateInput("server") && ValidateInput("baza") && (ValidateInput("korisnicko") || ckBox.Checked) && (ValidateInput("lozinka") || ckBox.Checked))
            {
                //RegistryKey InfosKey    = Registry.CurrentUser;
                //InfosKey                = InfosKey.CreateSubKey("SOFTWARE\\C#\\Infos-ProjectX");

                //InfosKey.SetValue("Server", "KRISTIJAN-HP\\SQLEXPRESS01");
                //InfosKey.SetValue("Database", "infosXDatabase");

                //InfosKey.SetValue("username", "infos");
                //InfosKey.SetValue("password", "infos");

                //InfosKey.Close();

                string server           = tboxNazivServera.Text;
                string database         = tboxImeBaze.Text;
                string username         = tboxKorisnickoIme.Text;
                string password         = tboxLozinka.Text;
                bool winAuth            = ckBox.Checked;

                string connectionString = "Data Source=" + server
                                            + ";Initial Catalog=" + database
                                            + ";Integrated Security=" + winAuth.ToString();                                    

                if (!winAuth)
                {
                    connectionString += ";User ID=" + username
                                     + ";Password=" + password
                                     + ";";
                }
            
                // If using SqlCredential Class rather than passing username and password in connection string; more secure
                //SecureString securePassword = new SecureString();
                //foreach (char c in password)
                //{
                //    securePassword.AppendChar(c);
                //}

                try
                {
                    SqlConnection infosConnection       = new SqlConnection(connectionString);
                    //SqlCredential infosCredentials      = new SqlCredential(username, securePassword);

                    //infosConnection.Credential          = infosCredentials;
                    infosConnection         .Open();

                    Console                 .WriteLine("State {0}", infosConnection.State);
                    Console                 .WriteLine("ConnectionString: {0}", infosConnection.ConnectionString);

                    Form1 form1             = new Form1();
                    form1                   .Show();

                    RegistryKey InfosKey    = Registry.CurrentUser;
                    InfosKey                = InfosKey.CreateSubKey("SOFTWARE\\C#\\Infos-ProjectX");

                    InfosKey                .SetValue("Server", server);
                    InfosKey                .SetValue("Database", database);

                    if (!ckBox.Checked)
                    {
                        InfosKey            .SetValue("username", username);
                        InfosKey            .SetValue("password", password);
                    }

                    infosConnection         .Close();
                    this                    .Hide();
                }
                catch
                {
                    MessageBox.Show("Pogrešni podaci. Molimo unesite ispravne podatke");
                }

            }
            else
            {
                MessageBox.Show("Molimo unesite sve potrebne podatke");
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBox.Checked)
            {
                tboxKorisnickoIme.Enabled       = false;
                tboxLozinka.Enabled             = false;
            }
            else
            {
                tboxKorisnickoIme.Enabled       = true;
                tboxLozinka.Enabled             = true;
            }
        }

        private void tboxNazivServera_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput("server");
        }

        private void tboxImeBaze_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput("baza");
        }

        private void tboxKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput("korisnicko");
        }

        private void tboxLozinka_Validating(object sender, CancelEventArgs e)
        {
            ValidateInput("lozinka");
        }

        private bool ValidateInput(string input)
        {
            bool bStatus            = true;
            TextBox box;
            ErrorProvider errProvider;

            switch (input)
            {
                case "baza":
                    box             = tboxImeBaze;
                    errProvider     = errProviderBaza;
                    break;

                case "korisnicko":
                    box             = tboxKorisnickoIme;
                    errProvider     = errProviderKorisnicko;
                    break;

                case "lozinka":
                    box             = tboxLozinka;
                    errProvider     = errProviderLozinka;
                    break;

                default:
                    box             = tboxNazivServera;
                    errProvider     = errProviderServer;
                    break;
            }

            if(box.Text == "")
            {
                errProvider         .SetError(box, "Molimo unesite podatke");
                bStatus             = false;
            }

            return bStatus;
        }
    }
}
