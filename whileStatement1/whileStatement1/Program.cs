using System;
using System.Threading;

namespace whileStatement1
{
    class Program
    {
        static void Main(string[] args)
        {
            int whileIndexOne = 0;

            while (whileIndexOne <= 6)
            {
                Console.WriteLine("whileIndexOne: " + whileIndexOne);
                Thread.Sleep(500);
                whileIndexOne++;
            }
        }
    }
}
