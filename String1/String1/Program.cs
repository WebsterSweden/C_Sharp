using System;
using System.Linq;

namespace String1
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringOne = "stringOne";

            Console.WriteLine(stringOne.Length);
            Console.WriteLine(stringOne.ToUpper());
            Console.WriteLine(stringOne.ToLower());
            Console.WriteLine(stringOne + stringOne);
            Console.WriteLine(string.Concat(stringOne, stringOne));

            StringComparer stringComparerOne = StringComparer.OrdinalIgnoreCase;
            Console.WriteLine(stringComparerOne.Compare("ABC", "abc"));
            Console.WriteLine(stringComparerOne.Equals("ABC", "abc"));

            Console.WriteLine("----------");
        }
    }
}
