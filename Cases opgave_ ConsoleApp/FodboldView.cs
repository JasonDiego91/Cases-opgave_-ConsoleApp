using MyProject_Cases__logic_and__classlibrary;
using System;

namespace Cases_opgave__ConsoleApp
{
    internal class FodboldView
    {
        public FodboldView()
        {

            Console.WriteLine("How many passes");
            var passses = Console.ReadLine();


            Fodbold obj1 = new Fodbold();
            var result = obj1.HowMuchDoWeCheer(passses);

            Console.WriteLine(result);
            Console.ReadKey();
        }

    }
}