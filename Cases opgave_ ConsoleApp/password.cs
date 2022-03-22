using MyProject_Cases__logic_and__classlibrary;
using System;


namespace Cases_opgave__ConsoleApp
{
    internal class password
    {

        public password()
        {
            MyMethod();

        }

        private void MyMethod()
        {
            
            string passWord;
            string brugernavn;
            bool godkendt;
            brugernavn = Console.ReadLine();
            passWord = Console.ReadLine();
            godkendt = true;
            string skrivtext = brugernavn + passWord;

            passwordlogic obj1 = new passwordlogic();
            obj1.PasswordMain(passWord, brugernavn, skrivtext, godkendt);



        }
    }

}


