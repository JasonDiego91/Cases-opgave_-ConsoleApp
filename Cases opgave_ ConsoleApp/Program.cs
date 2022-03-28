using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using logiclibrary;

namespace threecases
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
            string loginresultat = loginObjekt.loginforcases(brugernavnLogin, adgangskodeLogin);
            Console.WriteLine(loginresultat);
            Console.ReadKey();
            Console.Clear();


            if (loginresultat == "login er godkendt")
            {


                do
                {
                    
                    Console.WriteLine("vælg program - Fodbold (1) MilitaryTime (2) Dansekonkurrence (3) Password (4) eller tast sluk for at lukke");
                    indtast = Console.ReadLine();

                    switch (indtast)
                    {
                        case "1":
                            new FodboldView();
                            break;

                        case "2":
                            new MilitaryTimeView();
                            break;

                        case "3":
                            new DansekonkurrenceCase();
                            break;

                        case "4":
                            new adgangskodecase();
                            break;

                    }

                }

                while (indtast != "5");
                Console.WriteLine("lukker program");
                Console.ReadKey();
               


            }

        }

    }

}