using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logiclibrary
{
    public class Dansekonkurrencelogic
    {
        
        public int point1;
        public int point2 ;
        public int allepoint;
        public string navn1 = "";
        public string navn2 = "";
        public string allenavne = "";
        public string endesvar = "";
        public string alleNavneString = "";

        public static Dansekonkurrencelogic operator +(Dansekonkurrencelogic danse1, Dansekonkurrencelogic danse2)
        {
            Dansekonkurrencelogic udregning = new Dansekonkurrencelogic();
            udregning.allenavne = danse1.navn1 + $"&{danse2.navn2}";
            udregning.allepoint = danse1.point1 + danse2.point2;
            udregning.alleNavneString = udregning.allepoint.ToString();
            udregning.endesvar = udregning.allenavne + udregning.alleNavneString;
            
            return udregning;



        }

        
    }



}




