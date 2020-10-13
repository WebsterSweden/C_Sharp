using System;

namespace MultiDimensionalArray1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] twoDimensionalArrayOne = { };
            //Console.WriteLine(twoDimensionalArrayOne);

            //int[,] twoDimensionalArrayOne = {
            //{ },
            //{ },
            //{ }
            //};
            ////Console.WriteLine(twoDimensionalArrayOne[0, 0]);
            //Console.WriteLine(twoDimensionalArrayOne);

            int[,] twoDimensionalArrayOne = {
            {1, 2},
            {3, 4},
            {5, 6}
            };
            Console.WriteLine(twoDimensionalArrayOne[0, 0]);
            Console.WriteLine(twoDimensionalArrayOne[1, 0]);
            Console.WriteLine(twoDimensionalArrayOne[2, 1]);

            int[,] twoDimensionalArrayTwo = new int[,] {
            {1, 2},
            {3, 4},
            {5, 6}
            };
            Console.WriteLine(twoDimensionalArrayTwo[0, 0]);
            Console.WriteLine(twoDimensionalArrayTwo[1, 0]);
            Console.WriteLine(twoDimensionalArrayTwo[2, 1]);

            int[,] twoDimensionalArrayThree = new int[2, 3];
            twoDimensionalArrayThree[0, 0] = 1;
            twoDimensionalArrayThree[0, 1] = 2;
            twoDimensionalArrayThree[0, 2] = 3;
            twoDimensionalArrayThree[1, 0] = 4;
            twoDimensionalArrayThree[1, 1] = 5;
            twoDimensionalArrayThree[1, 2] = 6;
            Console.WriteLine(twoDimensionalArrayThree[0, 0]);
            Console.WriteLine(twoDimensionalArrayThree[0, 2]);
            Console.WriteLine(twoDimensionalArrayThree[1, 2]);
        }
    }
}
