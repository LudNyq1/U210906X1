using System;

namespace UPG6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rTal = rnd.Next(1, 21);
            int gissning = 0;
            Console.WriteLine("Gissa ett tal mellan 1-21: ");
            while (gissning != rTal) // Checkar om gissningen är lika med randomtalet, om inte fortsätter while loopen
            {
                gissning = int.Parse(Console.ReadLine());
                Console.WriteLine("Talet var fel, gissa igen!");
            }
            Console.WriteLine($"Grattis! Du gissade {rTal}");


        }
    }
}
