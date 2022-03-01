using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_Cases__logic_and__classlibrary
{
    public class Fodbold
    {
        public string HowMuchDoWeCheer(string antal)
        {
            string result = "";
            

            int aflevering = int.Parse(antal);

            if (aflevering >= 10 )
            {
                result = "High Five - Jubel!!!";
            }
            else if (aflevering < 1)
            {
                result = "Shh";
            }
            else
            {
                for (int i = 0; i < aflevering; i++)
                {
                    result = result + "Huh!!! ";
                }
            }

            
            return result;
            
        }
    }
       

    
}

