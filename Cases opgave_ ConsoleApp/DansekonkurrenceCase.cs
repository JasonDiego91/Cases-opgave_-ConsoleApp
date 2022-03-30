using logiclibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threecases
{
    internal class DansekonkurrenceCase
    {

        public DansekonkurrenceCase()
        {

            Console.WriteLine("hvad hedder den første danser ?");
            var navn = Console.ReadLine();

            Console.WriteLine("hvad hedder den anden danser ?");
            var navn2 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"hvor mange point fik {navn}?");
            var point = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"hvor mange point fik {navn2}?");
            var point2 = Convert.ToInt32(Console.ReadLine());

            danselogic dans1 = new danselogic(navn, point);
            danselogic dans2 = new danselogic(navn2, point2);

            danselogic total = dans1 + dans2;

            Console.Clear();

            Console.WriteLine("den første danser - {0} {1}", navn, point);

            Console.WriteLine("den anden danser - {0} {1}", navn2, point2);

            Console.WriteLine("indtast for at for at få det hele vist på en linje");

            Console.Clear();
            Console.WriteLine(total.navn);
            Console.WriteLine(total.point);

            Console.ReadKey();
            Console.Clear();

        }



    }

}
