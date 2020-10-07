using System;

namespace Random1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Random Object.
            Random randomNumberObject = new Random(DateTime.Now.Millisecond);
            //Console.WriteLine(randomNumber);

            // Random number range between 1 and 3.
            //int randomNumber_1_3 = randomNumberObject.Next(1, 4);
            //Console.WriteLine(randomNumber_1_3);

            for (int i = 1; i <= 10; i++)
            {
                int randomNumber_1_10 = randomNumberObject.Next(1, 11);
                Console.WriteLine(randomNumber_1_10);
            }

            // TODO: Array in ascending and descending order. Randomize elements.

        }
    }
}
