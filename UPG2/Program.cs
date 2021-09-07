using System;

namespace UPG2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in din mening:");
            string mening = Console.ReadLine();
            string[] meningLista = mening.Split(' '); //Skapa array av s, innehåller ord för ord



            /*for (int i = 0; i < meningLista.Length - 1; i++) //Sotera lista, fallande ordning
            {
                if (meningLista[i].Length < meningLista[i + 1].Length)
                {
                    string temp = meningLista[i];
                    meningLista[i] = meningLista[i + 1];
                    meningLista[i + 1] = temp;
                }
            }
            foreach (string ord in meningLista)
            {
                Console.WriteLine(ord);
            }*/
        }
    }
}
