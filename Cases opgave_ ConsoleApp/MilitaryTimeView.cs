using MyProject_Cases__logic_and__classlibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cases_opgave__ConsoleApp
{
    internal class MilitaryTimeView
    {
        public MilitaryTimeView()
        {
            MilitaryTime militaryTime = new MilitaryTime();


            militaryTime.ConvertTime(Console.ReadLine());
        }
    }
}
