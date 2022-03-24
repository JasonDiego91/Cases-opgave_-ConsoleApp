using logiclibrary;
using System;


namespace threecases_classes
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
            string replacetext = skrivtext;
            brugernavnlogic obj1 = new brugernavnlogic();
            obj1.PasswordMain(passWord, brugernavn, skrivtext,replacetext, godkendt);



        }
    }

}


