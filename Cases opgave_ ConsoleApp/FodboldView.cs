using System;
using logiclibrary;
namespace threecases
{
    internal class FodboldView
    {
        public FodboldView()
        {

            Console.WriteLine("Hvor mange afleveringer?");
            var aflevering = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Er der scoret så skriv mål");
            var mål = Console.ReadLine();
            Console.Clear();
            
            Fodboldlogic obj1 = new Fodboldlogic();
            var result = obj1.HowMuchDoWeCheer(aflevering, mål);




            Console.WriteLine(result);
            Console.ReadKey();
        }

    }
}