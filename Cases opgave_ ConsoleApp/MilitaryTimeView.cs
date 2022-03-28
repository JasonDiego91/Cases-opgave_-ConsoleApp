using logiclibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threecases
{
    internal class MilitaryTimeView
    {
        public MilitaryTimeView()
        {
            MilitaryTimelogic militaryTime = new MilitaryTimelogic();


            militaryTime.ConvertTime(Console.ReadLine());
        }
    }
}
