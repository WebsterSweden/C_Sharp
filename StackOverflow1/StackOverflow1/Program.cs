using System;

namespace StackOverflow1
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: How to catch the Stack overflow exception?
            // Expected output: Stack overflow.
            Program recursive = new Program();
            try { recursive.RecursiveMethod(); }
            catch (Exception exceptionMessage) { Console.WriteLine(exceptionMessage.Message); }
        }

        void RecursiveMethod()
        {
            RecursiveMethod();
        }
    }
}
