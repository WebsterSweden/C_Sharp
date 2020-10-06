using System;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayStringOne = { "ElementOne", "ElementTwo", "ElementThree" };

            for (int i = 0; i < arrayStringOne.Length; i++)
            {
                Console.WriteLine(arrayStringOne[i]);
            }

            // Create an Array.
            int[] arrayIntOne;
            arrayIntOne = new int[3];
            Console.WriteLine(arrayIntOne);

            // Create an Array.
            int[] arrayIntTwo = new int[3];
            Console.WriteLine(arrayIntTwo);

            // Create an Array and set size at runtime.
            Console.WriteLine("Enter Array size: ");
            int arraySize;
            arraySize = Convert.ToInt32(Console.ReadLine());
            //arraySize = 3;
            int[] arrayIntThree;
            arrayIntThree = new int[arraySize];

            for (int i = 0; i < arrayIntThree.Length; i++)
            {
                Console.WriteLine(i);
                //i++;
            }

        }
    }
}
