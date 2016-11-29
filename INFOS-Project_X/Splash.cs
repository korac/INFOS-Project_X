using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Data.SqlClient;
using System.Threading;

namespace INFOS_Project_X
{
    public partial class Splash : Form
    {
        bool serverOk = false;
        public Splash()
        {
            InitializeComponent();

            bworker.DoWork                              += Bworker_DoWork;
            bworker.RunWorkerCompleted                  += Bworker_RunWorkerCompleted;
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            this.Cursor                                 = Cursors.WaitCursor;
            bworker                                     .RunWorkerAsync();
        }

        private void Bworker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!serverOk)
            {
                Console.WriteLine("Error with server connection");

                ServerAuthForm authForm     = new ServerAuthForm();
                Thread                      .Sleep(2000);

                if (authForm.ShowDialog(this) == DialogResult.OK)
                {
                    this.DialogResult       = DialogResult.OK;
                }
                this.Cursor                 = Cursors.Default;
            }
            else
            {
                Thread.Sleep(2000);
                this.DialogResult           = DialogResult.OK;
            }
        }

        private void Bworker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                for (int i = 1; i <= 1000; i++)
                {
                    this.Invoke(new Action(() =>
                    {
                        lblProgress.Text    = i.ToString() + " / 1000";
                    }));
                }

                this.Invoke(new Action(() =>
                {
                    Change_Status("Prikupljam podatke o serveru...");
                    lblNaslov               .Refresh();
                    this                    .Invalidate();
                }));

                RegistryKey infosKey        = Registry.CurrentUser.OpenSubKey("SOFTWARE\\C#\\Infos-ProjectX");

                string server               = (string)infosKey.GetValue("Server");
                string database             = (string)infosKey.GetValue("database");
                string username             = (string)infosKey.GetValue("username");
                string password             = (string)infosKey.GetValue("password");
                bool winAuth                = false;

                string connectionString     = "Data Source=" + server
                                            + ";Initial Catalog=" + database
                                            + ";Integrated Security=" + winAuth.ToString();

                if (!winAuth)
                {
                    connectionString        += ";User ID=" + username
                                            + ";Password=" + password
                                            + ";";
                }
                else
                {
                    connectionString        += ";";
                }

                this.Invoke(new Action(() =>
                {
                    Change_Status("Pokušavam ostvariti konekciju s bazom...");
                }));

                SqlConnection infosConnection       = new SqlConnection(connectionString);

                infosConnection                     .Open();

                Console                             .WriteLine("State {0}", infosConnection.State);
                Console                             .WriteLine("Connection string: {0}", infosConnection.ConnectionString);

                this.Invoke(new Action(() =>
                {
                    Change_Status("Konekcija uspješno ostvarena...");
                }));

                infosConnection                     .Close();

                RegistryKey infosToRegistry         = Registry.CurrentUser.CreateSubKey("SOFTWARE\\C#\\Infos-ProjectX");

                infosToRegistry                     .SetValue("Server", server);
                infosToRegistry                     .SetValue("Database", database);

                PomocneFunkcije.connectionString    = connectionString;

                serverOk                            = true;

                this.Invoke(new Action(() =>
                {
                    Change_Status("Server spreman...Pristupam glavnom programu..");
                }));

            }
            catch
            {
                serverOk = false;
            }
        }

        private void Change_Status(string status)
        {
            lblSpajanje.Text    = status;
            lblSpajanje         .Refresh();
            Thread              .Sleep(1000);
        }
        
    }
}
