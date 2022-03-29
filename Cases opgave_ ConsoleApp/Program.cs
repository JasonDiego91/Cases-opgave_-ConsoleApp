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
            Console.Clear();
            
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
                    
                    Console.WriteLine("vælg program - fodbold - (1) dansekonkurrence - (2)  password ændring - (3)   for at lukke - (4)");
                    indtast = Console.ReadLine();

                    switch (indtast)
                    {
                        case "1":
                            new FodboldView();
                            break;

                        case "2":
                            new DansekonkurrenceCase();
                            break;

                        case "3":
                            new adgangskodecase();
                            break;
                                                    
                    }

                }

                while (indtast != "4");
                Console.WriteLine("lukker program");
                Console.ReadKey();
               


            }

        }

    }

}