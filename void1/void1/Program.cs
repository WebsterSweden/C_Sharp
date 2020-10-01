using System;

namespace void1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Local function can be made static.
            void MainVoidMethodOne()
            {
                return;
            }

            MainVoidMethodOne();

            // Local function can be made static.
            void MainVoidMethodTwo(string parameterOne)
            {
                // CS0127 Since 'Method' returns void, a return keyword must not be followed by an object expression.
                //return parameterOne;

                Console.WriteLine(parameterOne);

                string MainVoidMethodTwoStringVariable = "MainVoidMethodTwoStringVariable";
                Console.WriteLine(MainVoidMethodTwoStringVariable);
            }

            MainVoidMethodTwo("argumentOne");
        }
    }
}
