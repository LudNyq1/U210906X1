using System;

namespace UPG7
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z, "; //Alphabetet med mellanslag
            string leetSpeak = "4,8,(,|),3,|#,6,|-|,!,_),|(,1,|\\\\/|,|\\\\|,0,|>,?,|2,5,+,|_|,\\\\/,\\\\|/,%,`/,7_, "; //LeetSpeak alphabetet (a-z) med mellanslag

            string[] alphabetArray = alphabet.Split(','); //Konverterar alphabet stringen till en array
            string[] leetSpeakArray = leetSpeak.Split(','); //Konverterar leetSpeak stringen till en array

            /*ANVÄNDER EJ 2D ARRAY FÖR DET INTE BEHÖVS, MEN MAN KAN!*/

            Console.WriteLine("Skriv en mening utan å ä ö som ska översättas till Leet Speak:");
            char[] meningBokstäver = Console.ReadLine().ToCharArray(); //Omvandlar stringen som matas in till charArray
            string[] meningStringArray = new string[meningBokstäver.Length];
            for (int i = 0; i < meningBokstäver.Length; i++) //Omvandlar meningBokstäver till string[]
            {
                meningStringArray[i] = meningBokstäver[i].ToString();
            }

            string meningLeet = ""; // Skapar stringen pga enklare utskrift till Leet

            for (int i = 0; i < meningStringArray.Length; i++) // Kollar vilka platser i alphabet
                                                               // som motsvarar bokstäverna i meningStringArray,
                                                               // eftersom poisition 0 motsvarar a och 4 i både alphabetet och leetSpeak
                                                               // är listorna "parallella"
            {
                meningLeet += leetSpeakArray[Array.IndexOf(alphabetArray, meningStringArray[i])];
            }
            Console.WriteLine(meningLeet);


            Console.ReadLine();
        }
    }
}
