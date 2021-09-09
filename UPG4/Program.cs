using System;

namespace UPG4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in mening (små bokstäver):");
            char[] meningBsvr = Console.ReadLine().ToCharArray();
            char[] unikaBsvr1 = new char[meningBsvr.Length];
            int[] antal = new int[meningBsvr.Length];

            for (int i = 0; i < meningBsvr.Length; i++)
            {
                for (int j = 0; j < meningBsvr.Length; j++)
                {
                    if (meningBsvr[j] != ' ' && meningBsvr[j] != ',' && meningBsvr[j] != '.' && Array.IndexOf(unikaBsvr1, meningBsvr[j]) == -1)
                    //if satsen ovan kollar om alla bokstäver i meningBsvr inte redan finns i unikaBsvr eller om det inte är en bokstav.
                    {
                        unikaBsvr1[i] = meningBsvr[j];
                    }
                }
            }

            foreach (char i in unikaBsvr1)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < unikaBsvr1.Length; i++)
            {

            }

            
            /*
            for (int i = 0; i < unikaBsvr1.Length; i++)
            {
                for (int j = 0; j < meningBsvr.Length; j++)
                {
                    if (Array.IndexOf(meningBsvr, unikaBsvr1[i]) == -1 && meningBsvr[j] != ' ')
                    {
                        unikaBsvr1[i] = meningBsvr[Array.IndexOf(meningBsvr, meningBsvr[j])];
                    }
                }
            }
            
            
            int ctr1 = 0;
            for (int i = 0; i < unikaBsvr1.Length; i++)
            {
                if(unikaBsvr1[i] != ' ')
                {
                    ctr1++;
                }
            }
            char[] unikaBsvr2 = new char[ctr1];

            for (int i = 0; i < unikaBsvr2.Length; i++)
            {
                if (unikaBsvr1[i] != ' ')
                {
                    unikaBsvr2[i] = unikaBsvr1[i];
                }
            }
            
            foreach (char i in unikaBsvr2)
            {
                Console.WriteLine(i);
            }
            
            
            int[] antal = new int[unikaBsvr2.Length];
            for (int i = 0; i < unikaBsvr2.Length; i++)
            {
                int ctr = 0;
                for (int j = 0; j < unikaBsvr2.Length; j++)
                {
                    if (unikaBsvr2[i] == unikaBsvr1[j])
                    {
                        ctr++;
                    }
                }
                antal[i] = ctr;
            }

            for (int i = 0; i < ctr1; i++)
            {
                if (unikaBsvr2[i] != ' ')
                {
                    Console.WriteLine($"{unikaBsvr2[i]} ({antal[i]})");
                }
                
            }*/
            
        }
    }
}
