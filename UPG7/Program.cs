using System;

namespace UPG7
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z, ";
            string leetSpeak = "4,8,(,|),3,|#,6,|-|,!,_),|(,1,|\\\\/|,|\\\\|,0,|>,?,|2,5,+,|_|,\\\\/,\\\\|/,%,`/,7_, ";

            string[] alphabetArray = alphabet.Split(','); //Konverterar leetSpeak stringen till en array
            string[] leetSpeakArray = leetSpeak.Split(','); //Konverterar leetSpeak stringen till en array

            /*string[,] alphabetLeet2d = new string[26, 2];
            for(int i = 0; i < alphabetArray.Length; i++) //Foor loopen sätter in bokstäverna och dess motsvarande leetSpeak "tecken" i samma position.
            {
                alphabetLeet2d[i, 0] = alphabetArray[i];
                alphabetLeet2d[i, 1] = leetSpeakArray[i];
            }*/
            Console.WriteLine("Skriv en mening utan å ä ö:");

            char[] meningBokstäver = Console.ReadLine().ToCharArray();
            string[] meningStringArray = new string[meningBokstäver.Length];
            for(int i = 0; i < meningBokstäver.Length; i++)
            {
                meningStringArray[i] = meningBokstäver[i].ToString();
            }

            string meningLeet = "";

            for (int i = 0; i < meningStringArray.Length; i++)
            {
                meningLeet += leetSpeakArray[Array.IndexOf(alphabetArray, meningStringArray[i])];
            }
            Console.WriteLine(meningLeet);


            Console.ReadLine();
        }
    }
}
