using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logiclibrary
{
    public class Fodboldlogic
    {
        public string HowMuchDoWeCheer(string antal, string mål)
        {
            string result = "";
            string _mål = mål;

            int aflevering = int.Parse(antal);




            if (_mål == "mål")
            {
                result = "Olé olé ole";
                return result;

            }

            if (aflevering >= 10)
            {
                result = "High Five - Jubel!!!";
                return result;

            }

            if (aflevering < 1)
            {
                result = "Shh";
                return result;

            }

            else
            {
                for (int i = 0; i < aflevering; i++)
                {
                    result = result + "Huh!!! ";
                    return result;

                }

            }

            return "";





        }

    }



}

