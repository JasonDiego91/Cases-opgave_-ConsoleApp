using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject_Cases__logic_and__classlibrary;

namespace Cases_opgave__ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vælg program - Fodbold (1) MilitaryTime (2) Dansekonkurrence (3) Password (4)");

            int number = int.Parse(Console.ReadLine());

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

        }
    }
}
