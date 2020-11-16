using System;

namespace LambdaOperator1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;

            Func<int, int> multiplyByFive = num => num * 5;
            result = multiplyByFive(7);

            Func<int, int> multiplyByFiveReturnValue = num =>
            {
                int product = num * 5;
                return product;
            };
            result = multiplyByFive(7);

            Func<int, int, int> multiplyTwoNumbers = (a, b) => a * b;
            result = multiplyTwoNumbers(5, 7);
        }
    }
}
