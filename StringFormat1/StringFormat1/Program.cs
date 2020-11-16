using System;

namespace StringFormat1
{
    class Program
    {
        static void Main(string[] args)
        {
            int intOne = 9;

            // String format for int.
            Console.WriteLine(string.Format("{0}", intOne));
            Console.WriteLine(string.Format("{0:00}", intOne));
            Console.WriteLine(string.Format("{0:000000}", intOne));
        }
    }
}
