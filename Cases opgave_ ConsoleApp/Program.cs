using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using logiclibrary;

namespace threecases_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string indtast, brugernavnLogin, adgangskodeLogin;

            Console.WriteLine("velkommen til");
            Console.ReadKey();
            Console.WriteLine("indtast brugernavn: ");
            brugernavnLogin = Console.ReadLine().ToLower();
            Console.WriteLine("indstast adgangskode");
            adgangskodeLogin = Console.ReadLine();
            logiclibrary.loginlogic loginObjekt = new logiclibrary.loginlogic();
            string loginResultat = loginObjekt.loginforcases(brugernavnLogin, adgangskodeLogin);
            Console.WriteLine(loginResultat);
            Console.ReadKey();
            Console.WriteLine("vælg program - Fodbold (1) MilitaryTime (2) Dansekonkurrence (3) Password (4)");

            if (loginResultat == "login er godkendt")
            {

                do
                {
                    int number = int.Parse(Console.ReadLine());
                    indtast = Console.ReadLine().ToLower();
                    
                    switch (number)
                    {
                        case 1:
                            new FodboldView();
                            break;

                        case 2:
                            new MilitaryTimeView();
                            break;

                        case 3:
                            new DansekonkurrenceCase();
                            break;

                        case 4:
                            new password();
                            break;

                        default:
                            Console.WriteLine("Forkert indtasting");
                            break;

                    }
                    Console.ReadKey();
                } while (indtast != "sluk");
            }
            Console.ReadKey();
        }
    }
}
