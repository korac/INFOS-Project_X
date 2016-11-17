using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFOS_Project_X
{
    class PomocneFunkcije
    {
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
                if (!Char.IsLetter(l) && Char.ToString(l) != "." && Char.ToString(l) != " ")
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

    }
}
