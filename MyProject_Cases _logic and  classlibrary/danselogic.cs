using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logiclibrary
{
    public class danselogic
    {
        int point1 = 0;
        int point2 = 0;
        int allepoint;
        string navn1 = "";
        string navn2 = "";
        string allenavne = "";
        string endesvar;


        public static danselogic operator +(danselogic danse1, danselogic danse2)
        {
            

            danselogic udregning = new danselogic();
            danselogic svar = new danselogic();

            udregning.allenavne = danse1.navn1 + $"&{danse2.navn2}";

            udregning.allepoint = danse1.point1 + danse2.point2;

            udregning.endesvar = udregning.allenavne + udregning.allepoint;

            svar = udregning;

            return svar;
        }


    }

}















