using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logiclibrary
{
    public class danselogic
    {
        public int point;
        public string navn;


        public danselogic(string navn, int point)
        {
            this.navn = navn;
            this.point = point;
        }

        public static danselogic operator +(danselogic danser1, danselogic danser2)
        {
            string navne = danser1.navn + " & " + danser2.navn;
            int points = danser1.point + danser2.point;

            return new danselogic(navne, points);
        }


    }

}















