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
            foreach (string s in mening)
            {

                if (Array.IndexOf(unikaOrd1, s) == -1) //Om ordet s inte finns i unikaOrd, genomförs if satsen.
                                                       //Array.IndexOf() retunerar värdet -1 om den börjar söra på pos[0] men ej hittar värdet
                {
                    unikaOrd1[ctr1] = mening[Array.IndexOf(mening, s)]; //Hittar värdet på stringen s och sätter in det i unikaOrd
                    ctr1++;
                }

            }

            int ctr2 = 0;
            for (int i = 0; i < unikaOrd1.Length; i++) //Ser hur många platser som är fyllda i unikaOrd
            {
                if (unikaOrd1[i] != null)
                {
                    ctr2++;
                }
            }

            string[] unikaOrd2 = new string[ctr2];

            for (int i = 0; i < ctr2; i++) //Ser hur många platser som är fyllda i unikaOrd
            {
                unikaOrd2[i] = unikaOrd1[i];
            }

            int[] unikaOrdAntal = new int[unikaOrd2.Length];
            for (int i = 0; i < unikaOrd2.Length; i++)
            {
                int ctr = 0;
                for (int j = 0; j < mening.Length; j++)
                {
                    if (unikaOrd2[i] == mening[j])
                    {
                        ctr++;
                    }
                }
                unikaOrdAntal[i] = ctr;
            }

            Console.WriteLine("De unika orden och hur många gånger de förekommer:");
            for (int i = 0; i < unikaOrd2.Length; i++)
            {
                Console.WriteLine($"{unikaOrd2[i]} \t ({unikaOrdAntal[i]})");
            }

            for (int i = 0; i < unikaOrd2.Length - 1; i++) //Sorterar unikaOrdAntal och unikaOrd2 parallellt med varandra, fallande ordning.
            {
                if (unikaOrdAntal[i] > unikaOrdAntal[i + 1])
                {
                    int temp = unikaOrdAntal[i];
                    unikaOrdAntal[i] = unikaOrdAntal[i + 1];
                    unikaOrdAntal[i + 1] = temp;

                    string temp1 = unikaOrd2[i];
                    unikaOrd2[i] = unikaOrd2[i + 1];
                    unikaOrd2[i + 1] = temp1;

                    i = -1;
                }
            }
            Console.WriteLine("De unika orden sorterat i hur många gånger de förekommer i fallande ordning:");
            for (int i = 0; i < unikaOrd2.Length; i++)
            {
                Console.WriteLine($"{unikaOrd2[i]} \t ({unikaOrdAntal[i]})");
            }

            /*
            string[] s = { "jag", "cool", "ludvig", "ball", "koolalkalkalkalka"};
            Console.WriteLine(Array.IndexOf(s, "jagg")); //Om objektet inte finns i arrayen returnar den det sista 
            */
            Console.ReadLine();

        }
    }
}
