using System;

namespace UPG7
{
    class Program
    {
        static void Main(string[] args)
        {
            string leetSpeak = "4 8 ( |) 3 |# 6 |-| ! _) |( 1 |\\\\/| |\\\\| 0 |> ? |2 5 + |_| \\\\/ \\\\|/ % `/ 7_";
            string alphabet = "a b c d e f g h i j k l m n o p q r s t u v w x y z";

            string[] leetSpeakArray = leetSpeak.Split(' ');
            string[] alphabetArray = alphabet.Split(' ');
            Console.WriteLine(leetSpeak);
        }
    }
}
