using System;
using System.Reflection;

namespace ifStatement1
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool boolCheck = true;
            bool boolCheck = false;

            //if (boolCheck == true)
            //{
            //    Console.WriteLine("boolCheck: " + boolCheck);
            //}
            //else
            //{
            //    Console.WriteLine("boolCheck: " + boolCheck);
            //}

            // Unary ! (logical negation) operator.
            //if (!true)
            //{
            //    Console.WriteLine("Unary operator: " + true);
            //}
            //else
            //{
            //    Console.WriteLine("Unary operator: " + false);
            //}

            bool boolTrueOne = true;
            bool boolTrueTwo = true;
            bool boolFalseOne = false;
            bool boolFalseTwo = false;

            int intOne = 3;
            int intTwo = 3;

            if (boolTrueOne & boolTrueTwo)
            {
                Console.WriteLine("if boolTrueOne & boolTrueTwo: " + boolTrueOne + boolTrueTwo);
            }
            else
            {
                Console.WriteLine("else boolTrueOne & boolTrueTwo: " + boolTrueOne + boolTrueTwo);
            }

            if (boolTrueOne & boolFalseOne)
            {
                Console.WriteLine("if boolTrueOne & boolFalseOne: " + boolTrueOne + boolFalseOne);
            }
            else
            {
                Console.WriteLine("else boolTrueOne & boolFalseOne: " + boolTrueOne + boolFalseOne);
            }

            if (boolFalseOne & boolTrueOne)
            {
                Console.WriteLine("if boolFalseOne & boolTrueOne: " + boolFalseOne + boolTrueOne);
            }
            else
            {
                Console.WriteLine("else boolFalseOne & boolTrueOne: " + boolFalseOne + boolTrueOne);
            }

            //if (boolTrueOne && boolTrueTwo)
            //{
            //    //Console.WriteLine("boolTrueOne && boolTrueTwo: " + boolTrueOne + boolTrueTwo);
            //}

            //if (boolTrueOne & boolFalseOne)
            //{
            //    Console.WriteLine("boolTrueOne & boolFalseOne: " + boolTrueOne + boolFalseOne);
            //}
            //else
            //{
            //    Console.WriteLine("boolTrueOne & boolFalseOne: " + boolTrueOne + boolFalseOne);
            //}

            //if (boolTrueOne || boolTrueTwo)
            //{
            //    //Console.WriteLine("boolTrueOne || bootTrueTwo: " + boolTrueOne + boolTrueTwo);
            //}

            Console.WriteLine("----------");

            // TODO: if Statement with no brackets.

            int ifWithNoBracketOne = 3;
            int ifWithNoBrackettwo = 6;

            if (ifWithNoBracketOne <= 3 && ifWithNoBrackettwo <= 6)
                Console.WriteLine("First statement: " + Convert.ToInt32(ifWithNoBracketOne + Convert.ToInt32(ifWithNoBracketOne)));

            //if (true)
            //    return false;
            //else
            //    return true;

            //if (true)
            //    methodOne();
            //methodTwo();
        }
    }
}
