using System;

namespace UPG5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en mening, för att avsluta skriv: \"AVSLUTA\"");
            string mening = "";
            bool a = true;
            while (a)
            {
                string s = Console.ReadLine();

                if (s != "AVSLUTA") //Sålänge string s inte är lika med avsluta är a = true, annats a = false och while loopen bryts.
                {
                    mening += (s + " ");
                }
                else
                {
                    a = false;
                }
            }
            Console.WriteLine(mening);

        }
    }
}
