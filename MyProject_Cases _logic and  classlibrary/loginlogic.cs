using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logiclibrary
{
    public class loginlogic
    {
        public string loginforcases(string brugernavnLogin, string adgangskodeLogin)
        {
            var loginresultat = login(brugernavnLogin, adgangskodeLogin);

            if (!string.IsNullOrEmpty(loginresultat))
            {
                return loginresultat;
            }
            else
            {
                return "forkert indtasting";

            }

        }
        private string login(string brugernavnLogin, string adgangskodeLogin)
        {
            string bruger = System.IO.File.ReadAllText(@"C:\Users\jassmi\Desktop\Bruger.txt");
            
            string adgangskode = System.IO.File.ReadAllText(@"C:\Users\jassmi\Desktop\adgangskoder.txt");

            if (bruger == brugernavnLogin && adgangskode == adgangskodeLogin)
            {
                return "login er godkendt";
            }
            else
            {
                return "forkert brugernavn eller adgangskode";
            }


        }
    }
}
