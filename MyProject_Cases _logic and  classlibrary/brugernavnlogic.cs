using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace logiclibrary
{
    public class brugernavnlogic

    {
        public string PasswordMain(string passWord, string brugernavn, string skrivtext, string replacetext, bool godkendt )
        {
            string tast = "";

            while (tast != "4")
            {
                Console.Clear();
                Console.WriteLine("tast nummer 1 for oprettelse af bruger");
                Console.WriteLine("tast nummer 2 for at se en oversigt af brugere");
                Console.WriteLine("tast nummer 3 for at ændre brugernavn");
                Console.WriteLine("tast nummer 4 for at afslutte");
                tast = Console.ReadLine();

                switch (tast)
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("opret bruger");
                            Console.Write("indsæt brugernavn: ");
                            brugernavn = Console.ReadLine();
                            Console.Write("indsæt password: ");
                            passWord = Console.ReadLine();

                            skrivtext = brugernavn + "\n" + passWord;

                            using (StreamWriter file = new StreamWriter(@"C:\Users\jassmi\Desktop\Bruger&Pass.txt", true))
                            {
                                file.WriteLine(skrivtext);
                            }
                            Console.WriteLine("bruger oprettet");
                            Console.ReadKey();
                            break;
                        }
                    case "2":
                        {
                            Console.Clear();
                            Console.WriteLine("oversigt af bruger");
                            string[] lines =
                            File.ReadAllLines(@"C:\Users\jassmi\Desktop\Bruger&Pass.txt");

                            Console.WriteLine("indhold af Bruger&Pass.txt = ");
                            foreach (string line in lines)
                            {
                                Console.WriteLine("\t" + line);
                            }
                            Console.WriteLine("tryk en tast for at kommme tilbage");
                            Console.ReadKey();
                            break;
                        }

                    case "3":
                        {
                           
                            Console.Clear();
                            Console.WriteLine("ændrer password");
                            passWord = Console.ReadLine();

                            skrivtext =  brugernavn +"\n"+ passWord;
                            replacetext =  brugernavn +"\n"+ passWord;
                            StreamReader reader = new StreamReader(@"C:\Users\jassmi\Desktop\Bruger&Pass.txt");
                            
                            string content = reader.ReadToEnd();
                            reader.Close();

                            content = Regex.Replace(content,skrivtext, replacetext);

                            StreamWriter writer = new StreamWriter(@"C:\Users\jassmi\Desktop\Bruger&Pass.txt");
                            writer.Write(content);
                            writer.Close();
                            Console.WriteLine("ændring af password oprettet");
                            Console.Clear();
                            Console.WriteLine("tryk en tast for at kommme tilbage");
                            Console.ReadKey();
                            break;

                        }

                    case "4":
                        {
                            Console.Clear();
                            Console.WriteLine("lukker program");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("forkert brugernavn og adgangskode");
                            break;
                        }
                }



            }
            Console.ReadKey();
            return "";


        }
    }
}

