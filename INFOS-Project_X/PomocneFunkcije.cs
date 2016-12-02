using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace INFOS_Project_X
{
    class PomocneFunkcije
    {
        public static string connectionString;

        public static void AutoSizeDgvColumns(DataGridViewColumnCollection dgvColumns)
        {
            for (int i = 0; i < dgvColumns.Count; i++)
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

        public static bool IDExists(string ID, MaticniPodaci matpod)
        {
            switch (matpod)
            {
                case MaticniPodaci.Clan:

                    infosXDatabaseDataSetTableAdapters.ClanTableAdapter clanTA          = new infosXDatabaseDataSetTableAdapters.ClanTableAdapter();

                    var clanOibCount        = clanTA.CheckIfOibExists(ID);
                    if (clanOibCount.HasValue && clanOibCount > 0)
                    {
                        return false;
                    }
                    return true;
                    break;

                case MaticniPodaci.Drustva:

                    infosXDatabaseDataSetTableAdapters.DrustvoTableAdapter drustvoTA    = new infosXDatabaseDataSetTableAdapters.DrustvoTableAdapter();

                    var drustvoIDCount      = drustvoTA.CheckIfIDExists(ID);
                    if (drustvoIDCount.HasValue && drustvoIDCount > 0)
                    {
                        return false;
                    }
                    return true;
                    break;

                case MaticniPodaci.Mjesta:

                    infosXDatabaseDataSetTableAdapters.MjestoTableAdapter mjestoTA      = new infosXDatabaseDataSetTableAdapters.MjestoTableAdapter();

                    var mjestoIDCount       = mjestoTA.CheckIfIDExists(ID);
                    if (mjestoIDCount.HasValue && mjestoIDCount > 0)
                    {
                        Console.WriteLine(mjestoIDCount);
                        return false;
                    }
                    return true;
                    break;

                case MaticniPodaci.Drzave:

                    infosXDatabaseDataSetTableAdapters.DrzavaTableAdapter drzavaTA      = new infosXDatabaseDataSetTableAdapters.DrzavaTableAdapter();

                    var drzavaIDCount       = drzavaTA.CheckIfIDExists(ID);
                    if (drzavaIDCount.HasValue && drzavaIDCount > 0)
                    {
                        return false;
                    }
                    return true;
                    break;

                default:
                    return false;
            }
        }

        public static bool IsValidIme(string ime)
        {
            foreach (char l in ime)
            {
                if (!Char.IsLetter(l) && Char.ToString(l) != " ")
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsValidNaziv(string naziv)
        {
            foreach (char l in naziv)
            {
                if (!Char.IsLetter(l) && Char.ToString(l) != "." && Char.ToString(l) != " " && Char.ToString(l) != "-")
                {
                    return false;
                }
            }
            return true;
        }

        public static bool isValidAdresa(string adresa)
        {
            foreach (char l in adresa)
            {
                if (!Char.IsLetter(l) && !Char.IsDigit(l) && Char.ToString(l) != " ")
                {
                    return false;
                }
            }
            return true;         
        }

        public static bool isValidTelefon(string telefon)
        {
            foreach (char l in telefon)
            {
                if (!Char.IsDigit(l) && Char.ToString(l) != "-" && Char.ToString(l) != " ")
                {
                    return false;
                }
            }
            return true;
        }

        public static bool isValidPozivni(string pozivniBroj)
        {
            foreach (char l in pozivniBroj)
            {
                if (!Char.IsDigit(l) && Char.ToString(l) != "+")
                {
                    return false;
                }
            }
            return true;
        }

        public static bool isValidBrojRacuna(string racun)
        {
            foreach (char l in racun)
            {
                if(!Char.IsDigit(l) && !Char.IsLetter(l))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool isValidOIB(string oib)
        {
            if (oib.Length != 11) return false;

            long b;
            if (!long.TryParse(oib, out b)) return false;

            int a = 10;
            for (int i = 0; i < 10; i++)
            {
                a = a + Convert.ToInt32(oib.Substring(i, 1));
                a = a % 10;
                if (a == 0) a = 10;
                a *= 2;
                a = a % 11;
            }
            int kontrolni = 11 - a;
            if (kontrolni == 10) kontrolni = 0;

            return kontrolni == Convert.ToInt32(oib.Substring(10, 1));
        }

        public static bool isValidDatumRodenja(string datum)
        {
            DateTime value;
            if(DateTime.TryParse(datum, out value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
