using MyProject_Cases__logic_and__classlibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cases_opgave__ConsoleApp
{
    internal class DansekonkurrenceCase
    {
        public DansekonkurrenceCase()
        {
            Console.WriteLine("Hvad hedder den første danser ?");
            var navn1 = Console.ReadLine();

            Console.WriteLine("Hvad hedder den anden danser ?");
            var navn2 = Console.ReadLine();

            Console.WriteLine($"hvor mange point fik {navn1}?");
            var point1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"hvor mange point fik {navn2}?");
            var point2 = Convert.ToInt32(Console.ReadLine());

            Dansekonkurrencelogic Dansekonkurrenceclass = new Dansekonkurrencelogic();
            var udregning = Dansekonkurrenceclass; 

            Console.WriteLine(udregning.endesvar); 
            
            Console.ReadKey();

        }

    }
}