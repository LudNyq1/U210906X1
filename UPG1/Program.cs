using System;

namespace UPG1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en mening:");

            string mening = Console.ReadLine();
            string[] meningArray = mening.Split(' ');   // Delar upp orden i meningen och sätter in dom i en Array, ' ' är divider
            Console.WriteLine("Din mening innehåller: " + meningArray.Length + " ord");     //Skriver ut antal ord som är lagrat i Arrayebn
            for (int i = 0; i < meningArray.Length; i++)    //För varje ord loopas for-iterationen och skriver ut antal bokstäver
            {

                Console.WriteLine(meningArray[i] + " har " + meningArray[i].Length + " bokstäver!");
            }

            Console.ReadLine();
        }
    }
}