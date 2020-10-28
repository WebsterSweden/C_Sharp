using System;
using System.Collections.Generic;
using System.Text;

namespace Method2
{
    class MethodOne
    {
        public static int MethodPublicStaticIntNoParameter()
        {
            Console.Write("First number: ");
            int inputOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number: ");
            int intputTwo = Convert.ToInt32(Console.ReadLine());
            int result = inputOne * intputTwo;
            return result;
        }

        public static int MethodPublicStaticIntWithParameter(int parameterOne, int parameterTwo)
        {
            int result = parameterOne * parameterTwo;
            return result;
        }

        public static void MethodPublicStaticVoidNoParameter()
        {
            Console.Write("First number: ");
            int inputOne = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number: ");
            int intputTwo = Convert.ToInt32(Console.ReadLine());
            int result = inputOne * intputTwo;
            Console.WriteLine(result);
        }

        public static void MethodPublicStaticVoidWithParameter(int parameterOne, int parameterTwo)
        {
            int result = parameterOne * parameterTwo;
            Console.WriteLine(result);
        }
    }
}
