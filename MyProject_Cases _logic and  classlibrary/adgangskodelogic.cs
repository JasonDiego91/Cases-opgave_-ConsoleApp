using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace logiclibrary
{
    public class adgangskodelogic

    {
        public string BrugernavnOgKeyword(string brugernavn, string keyword)
        {
            var loginresultat = godkendt(brugernavn, keyword);

            if (!string.IsNullOrEmpty(loginresultat))
            {
                return loginresultat;
               
            }
            else
            {
                return "forkert indtasting";
            }


        }

        private string godkendt(string brugernavn, string keyword)
        {
            string fejltext = "adgangskoden skal mininum være på 12 tegn, der skal være et stort og småt bogstav mininum et tal og et special tegn. tal må ikke være i starten eller slutningen, hellere ingen mellemrum";

            bool MindstEtStortBogstav = keyword.Any(char.IsUpper); // minimum have et stort bogstav

            bool MindstEtSmåtBogstav = keyword.Any(char.IsLower);// minimum et småt bogstav

            bool EtSpecialtegn = keyword.Any(ch => !char.IsLetterOrDigit(ch)); // minimum et specielt teng

            bool EtTalMindst = keyword.Any(char.IsDigit); // minimum et tal

            bool IngenTalIStarten = !string.IsNullOrEmpty(keyword) && char.IsLetter(keyword[0]); // ingen tal i starten

            bool IngenTalISlutningen = !string.IsNullOrEmpty(keyword) && char.IsLetter(keyword.LastOrDefault()); // ingen tal i slutningen

            bool IngenMellemrum = keyword.Contains(" "); // ingen mellemrum

            if (MindstEtStortBogstav == false || MindstEtSmåtBogstav == false || EtTalMindst == false ||EtSpecialtegn == false || IngenTalIStarten == false || IngenTalIStarten == false || IngenMellemrum == true)
            // hvis en af kravene ikke er opfyldt giver den en fejlmeddelelse

            {
                return fejltext; // den returner string
            }
            else
            {
                string brugerfil = @"C:\Users\jassmi\Desktop\Bruger.txt"; //string til en sti

                string adgangskodefil = @"C:\Users\jassmi\Desktop\adgangskoder.txt";

                System.IO.File.WriteAllText(brugerfil, brugernavn); // to koder overskriver alt der er inde i tekstdokumentet

                System.IO.File.WriteAllText(adgangskodefil, keyword);

                return brugernavn + " " + keyword; // viser brugernavn og adgangskode
            }

        }
    }
}











