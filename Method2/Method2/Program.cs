using System;

namespace Method2
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Non-Static Methods.
            // TODO: Test difference between Non-Static and Static Methods.

            //Console.Write("First number: ");
            //int inputOne = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Second number: ");
            //int intputTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MethodOne.MethodPublicStaticIntNoParameter());

            //Console.WriteLine(MethodOne.MethodPublicStaticIntWithParameter(inputOne, intputTwo));

            //MethodOne.MethodPublicStaticVoidNoParameter();

            //MethodOne.MethodPublicStaticVoidWithParameter(inputOne, intputTwo);
        }
    }
}
