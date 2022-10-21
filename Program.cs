using System;
using System.Collections.Generic;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string string0 = "1234=5ABCD+abcd@";
            string string1 = "Hello";
            string string2 = "Johny!";
            string string3 = "Hello and hi";
            string result = Convert.ToString(Compare(string1, string2));
            Console.WriteLine(result);
            Analyze(string0, out int letters, out int digits, out int symbols);
            Console.WriteLine("letters" + " " + letters + " " + "digits" + " " + digits 
            + " " + "symbols" + " " + symbols);
            Sort(string1);
            Duplicate(string3);
            Console.ReadLine();
        }

        static bool Compare(string string1, string string2)
        {
            if (string1 == string2)
                return true;
            else
                return false;
        }

        static int Analyze(string string0, out int letters, out int digits, out int symbols)
        {
            char[] charArray = string0.ToCharArray();
            letters = 0;
            digits = 0;
            symbols = 0;
            foreach (char c in charArray)
                if (Char.IsLetter(c))
                {
                    letters++;
                }
                else if (Char.IsDigit(c))
                {
                    digits++;
                }
                else if (!Char.IsLetterOrDigit(c))
                {
                    symbols++;
                }
            return 0;
        }

        static void Sort(string string4)
        {
            string toLower = string4.ToLower();
            char[] charArray = toLower.ToCharArray();
            Array.Sort(charArray);
            string newString = string.Join("", charArray);
            Console.WriteLine("Sorted string:" + " " + newString);
        }

        static void Duplicate(string string5)
        {            
            string toLower = string5.ToLower();            
            var duplicates = new List<char>();
            foreach (var item in toLower)
            {
                if (toLower.IndexOf(item) != toLower.LastIndexOf(item) &&
                    !duplicates.Contains(item))
                {
                    duplicates.Add(item);
                }
            }
            Console.WriteLine("Duplicates are:" + string.Join(",", duplicates));
        }
    }
}