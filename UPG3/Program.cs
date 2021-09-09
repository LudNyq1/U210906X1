using System;

namespace UPG3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in din mening:");

            string[] mening = Console.ReadLine().Split(' ') /*{ "jag", "heter", "ludvig", "jag", "bajs", "heter" }*/;
            string[] unikaOrd1 = new string[mening.Length];
            int ctr1 = 0;
            foreach(string s in mening)
            {
                
                if (Array.IndexOf(unikaOrd, s) == -1) //Om ordet s inte finns i unikaOrd, genomförs if satsen.
                                                      //Array.IndexOf() retunerar värdet -1 om den börjar söra på pos[0] men ej hittar värdet
                {
                    unikaOrd[ctr1] = mening[Array.IndexOf(mening, s)]; //Hittar värdet på stringen s och sätter in det i unikaOrd
                    ctr1++;
                }
                
            }

            int ctr2 = 0;
            for (int i = 0; i < unikaOrd1.Length; i++) //Ser hur många platser som är fyllda i unikaOrd
            {
                if (unikaOrd1[i] != "")
                {
                    ctr2++;
                }
            }

            string[] unikaOrd2 = new string[ctr2];

            for (int i = 0; i < unikaOrd1.Length; i++) //Ser hur många platser som är fyllda i unikaOrd
            {
                if (unikaOrd1[i] != "") //Om unikaOrd1[i] är en tom plats genomförs ej if-satsen, orden tilldelas ej till arrayen unikaOrd2
                                       
                {
                    unikaOrd2[i] = unikaOrd1[i];
                }
            }





            foreach (string i in unikaOrd2)
            {
                Console.WriteLine(i);
            }
            /*
            string[] s = { "jag", "cool", "ludvig", "ball", "koolalkalkalkalka"};
            Console.WriteLine(Array.IndexOf(s, "jagg")); //Om objektet inte finns i arrayen returnar den det sista 
            */
            Console.ReadLine();

        }
    }
}
