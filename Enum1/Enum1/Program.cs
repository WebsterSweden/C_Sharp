using System;

namespace Enum1
{
    class Program
    {
        enum EnumOne
        {
            First,
            Second,
            Third
        }

        enum EnumTwo
        {
            Fourth = 4,
            Fifth = 5,
            Sixth = 6
        }

        static void Main(string[] args)
        {
            Console.WriteLine(EnumOne.First);

            Console.WriteLine(EnumTwo.Fifth);
        }
    }
}
