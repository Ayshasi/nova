using System;
using System.Text.RegularExpressions;

namespace RegExApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"D:\Alt-Text_Meta_GSLSpecPub2023-112";
            string pattern = @"^[a-zA-Z0-9_\-:\\\.<]+"; // allows valid path chars

            Regex rgx = new Regex(pattern);
            bool isValid = rgx.IsMatch(input);

            if (isValid)
            {
                Console.WriteLine("The input address is valid.");
            }
            else
            {
                Console.WriteLine("The input address is invalid.");
            }

            Console.ReadKey();
        }
    }
}
