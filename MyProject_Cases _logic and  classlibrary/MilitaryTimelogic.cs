using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_Cases__logic_and__classlibrary
{
    public class MilitaryTimelogic
    {
        //Access Level,
        //return type (string int, bool, object, ect.)
        //Method name
        //() -> input parameterne (string int, bool, object, ect.) 7:59 pm
        // funtionalitet
        //retun of the result
        public string ConvertTime(string s)
        {
            string[] subs = s.Split(' ', ':');

            s = "";

            int hours = int.Parse(subs[0]);

            if (subs[2].ToLower() == "pm")
            {
                hours += 12;
            }

            s = string.Format("{0}:{1}", hours, subs[1]);

            return s;
        }


        public string ConvertTimeToDateTime(string s)
        {
            s = ConvertTime(s);

            return DateTime.Parse(s).ToString("HH:mm");
        }

        public DateTime ConvertTimeToDateTime2(string s)
        {
            s = ConvertTime(s);

            return DateTime.Parse(s);
        }
    }
}
