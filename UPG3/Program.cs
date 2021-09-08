using System;

namespace UPG3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Mata in mening:");
            string mening = Console.ReadLine();
            string[] ord = mening.Split(' ');

            string[] ordUnika = new string[]; //Här läggs alla unika ord in varteftersom
            //string ordUnikaString = string.Join(" ", ordUnika);
            int[] ordUnikaAntal = new int[999]; //Platserna i denna array är paralella med ord1
            for(int i = 0; i < ord.Length - 1; i++)
            {
                Console.WriteLine("For i");
                string ordUnikaString = string.Join(" ", ordUnika);
                int counter = 1;
                if (ord[i].Contains(ordUnikaString) == false) //Vill kolla att om if-statement är false så ska den fortsätta
                {
                    

                    for (int j = 1; j < ord.Length; j++)
                    {
                        Console.WriteLine("For j");
                        /*Nedan kollar först om ord[i] är lika med ord[j] och sedan om ord[i]
                        redan finns i ordUnikaString(om ord[i] ej redan finns där aka == false
                        kommer den att fortsätta med statementet)*/
                        if (string.Equals(ord[i], ord[j]) == true /*& ord[i].Contains(ordUnikaString) == false*/)
                        {
                            ordUnika[i] = ord[i];
                            counter++;
                        }
                    }

                    ordUnikaAntal[i] = counter;
                }   
                    

            }

            Console.WriteLine("Loop klar\n");
            
            foreach(string ord1 in ordUnika)
            {
                Console.WriteLine(ord1);
                Console.WriteLine("1");
            }


            //Kommentaren nedan kommer att vara true, "StringComparisona.OrdinalIgnoreCase" betyder att Equals klassen
            //ska ignorera stora och små bokstäver!
            /*string a = "ludvig";
            string b = "Ludvig";
            bool c = string.Equals(a, b, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(c);
            string[] a1 = { "Ludvig", "cool", "jag" };
            string b1 = "ludvig";
            string b2 = "cool";
            string b3 = "jag";

            string a12 = string.Join(" ", a1); //Skapar en sträng av listan a1, med mellanrum mellan varje ord
            Console.WriteLine(a12 + "\n");
            Console.WriteLine(a12.Contains(b1));*/
             


            Console.ReadLine();
            
        }
    }
}
