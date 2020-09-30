using System;

namespace Variable1
{
    class Program
    {
        string stringTwo = "stringTwo";

        static void Main(string[] args)
        {
            string stringOne = "stringOne";
            Console.WriteLine(stringOne);
            stringOne = "stringOneNewValue";
            Console.WriteLine(stringOne);
        }
    }
}
