using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject_Cases__logic_and__classlibrary
{
    public class passwordlogic

    {
        public string PasswordMain(string passWord, string brugernavn, string skrivtext, bool godkendt)
        {
            string tast = "";

            while (tast != "4")
            {
                Console.Clear();
                Console.WriteLine("Tryk 1 for oprettelse af bruger");
                Console.WriteLine("Tryk 2 for at se en oversigt af brugere");
                Console.WriteLine("Tryk 3 for at ændre brugernavn");
                Console.WriteLine("Tryk 4 for at afslutte");
                tast = Console.ReadLine();

                switch (tast)
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("OPRET BRUGER");
                            Console.Write("Indsæt brugernavn: ");
                            brugernavn = Console.ReadLine();
                            Console.Write("Indsæt password: ");
                            passWord = Console.ReadLine();

                            skrivtext = "NAVN -" + brugernavn + "PASSWORD - " + passWord;

                            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\jassmi\Desktop\Bruger&Pass.txt", true))
                            {
                                file.WriteLine(skrivtext);
                            }
                            Console.WriteLine("Bruger oprettet");
                            Console.ReadKey();
                            break;
                        }
                    case "2":
                        {
                            Console.Clear();
                            Console.WriteLine("Oversigt af brugernavn");
                            string[] lines =
                            System.IO.File.ReadAllLines(@"C:\Users\jassmi\Desktop\Bruger&Pass.txt");

                            System.Console.WriteLine("Indhold af Bruger&Pass.txt = ");
                            foreach (string line in lines)
                            {
                                Console.WriteLine("\t" + line);
                            }
                            Console.WriteLine("Tryk en tast for at kommme tilbage");
                            Console.ReadKey();
                            break;
                        }

                    case "3":
                        {
                            Console.Clear();
                            Console.WriteLine("OPRET BRUGER");
                            Console.Write("Indsæt brugernavn: ");
                            brugernavn = Console.ReadLine();
                            Console.Write("Indsæt password: ");
                            passWord = Console.ReadLine();

                            skrivtext = "NAVN -" + brugernavn + "PASSWORD - " + passWord;

                            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\jassmi\Desktop\Bruger&Pass.txt", true))
                            {
                                file.WriteLine(skrivtext);
                            }
                            Console.WriteLine("Bruger oprettet");
                            Console.Clear();
                            Console.WriteLine("Tryk en tast for at kommme tilbage");
                            Console.ReadKey();
                            break;
                        }

                    case "4":
                        {
                            Console.Clear();
                            Console.WriteLine("Nedlukker program");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ugyldig tast");
                            break;
                        }
                }



            }
            Console.ReadKey();
            return "";


        }
    }
}

