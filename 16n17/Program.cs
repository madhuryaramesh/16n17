using System;

namespace _16n17
{  
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "LISTEN";
            string str2 = "SILENT";

            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("Anagram-------{0}----{1}", val1, val2);
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }
        }
    }
}
