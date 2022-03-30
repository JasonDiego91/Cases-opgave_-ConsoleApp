using logiclibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace threecases
{
    internal class adgangskodecase
    {

        public adgangskodecase() 
        {
            start();
        
        }



        private void start()
        {

            string brugernavn, keyword;

            Console.Clear();
            Console.WriteLine("velkommen til adgangskode menuen");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("indtast brugernavn");
            brugernavn = Console.ReadLine().ToLower();

            Console.WriteLine("indtast adgangskode");
            keyword = Console.ReadLine();

            logiclibrary.adgangskodelogic adgangskodeObjekt = new logiclibrary.adgangskodelogic();
            string adgangskoderesultat = adgangskodeObjekt.BrugernavnOgKeyword(brugernavn, keyword);
            Console.WriteLine(adgangskoderesultat);
            Console.ReadKey();
            Console.Clear();
        }

    }
}





