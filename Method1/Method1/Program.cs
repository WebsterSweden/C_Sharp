using System;

namespace Method1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Local function can be made static.
            void MainMethodOne()
            {
                Console.WriteLine("MainMethodOne");
            }

            MainMethodOne();

            static void MainMethodTwo()
            {
                Console.WriteLine("MainMethodTwo");
            }

            MainMethodTwo();

            Console.WriteLine(ClassOne.classOneString);

            Console.WriteLine(ClassOne.ClassOneMethodOne());
        }
    }
}
