using System;
using System.ComponentModel;
using System.Linq;

namespace PO_Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "Happy Birthday";
            test = swapCase(test);
            Console.WriteLine(test);

            test = "MANY THANKS";
            test = swapCase(test);
            Console.WriteLine(test);

            test = "sPoNtAnEoUs";
            test = swapCase(test);
            Console.WriteLine(test);
        }


        public static string swapCase(string s)
        {
            string swap = new string(
                s.Select(c => char.IsLetter(c) ? (char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)) : c).ToArray());
            return swap;
        }
    }
}
