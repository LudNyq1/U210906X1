using System;

namespace UPG2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in din mening:");
            string mening = Console.ReadLine();
            string[] ord = mening.Split(' '); //Skapa array av mening innehållande ord för ord

            //For satsen nedan sorterar ord-listan i fallande ordning (Störst till minst)
            Console.WriteLine("Orden i fallande ordning: ");
            for (int i = 0; i < ord.Length - 1; i++) 
            {
                if (ord[i].Length < ord[i + 1].Length)
                {
                    string temp = ord[i];
                    ord[i] = ord[i + 1];
                    ord[i + 1] = temp;

                    i = -1;
                }
            }
            foreach (string i in ord)
            {
                Console.WriteLine(i);
            }

            //For satsen nedan sorterar ord-listan i stigande ordning (Minst till störst)
            Console.WriteLine("Orden i stigande orden: ");
            for (int i = 0; i < ord.Length - 1; i++)
            {
                if (ord[i].Length > ord[i + 1].Length)
                {
                    string temp = ord[i];
                    ord[i] = ord[i + 1];
                    ord[i + 1] = temp;

                    i = -1;
                }
            }
            foreach (string i in ord)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();

        }
    }
}
