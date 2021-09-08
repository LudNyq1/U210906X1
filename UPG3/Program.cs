using System;

namespace UPG3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in din mening:");

            string[] mening = Console.ReadLine().Split(' ') /*{ "jag", "heter", "ludvig", "jag", "bajs", "heter" }*/;
            string[] unikaOrd = new string[mening.Length];
            int ctr = 0;
            foreach(string s in mening)
            {
                
                if (Array.IndexOf(unikaOrd, s) == -1) //Om ordet s inte finns i unikaOrd, genomförs ej if satsen.
                {
                    unikaOrd[ctr] = mening[Array.IndexOf(mening, s)]; //Hittar värdet på stringen s och sätter in det i unikaOrd
                    ctr++;
                }
                
            }

            foreach (string i in unikaOrd)
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
