using System;

namespace Constructor3
{
    class Program
    {
        static void Main(string[] args)
        {
            One one = new One();
            Console.WriteLine(one);

            One stringOneParameter = new One("stringOneArgument");

            One stringOneParameterStringTwoParameter = new One("stringOneArgument", "stringTwoArgument");

            One intOneParameter = new One(3);

            One intOneParameterIntTwoParameter = new One(3, 6);

            One stringOneParameterIntOneParameter = new One("stringOneArgument" + 3);

            One intTwoParameterStringTwoParameter = new One(6, "stringTwoArgument");
        }
    }
}
