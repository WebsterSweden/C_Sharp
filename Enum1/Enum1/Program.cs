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

        enum Months
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        static void Main(string[] args)
        {
            Console.WriteLine(EnumOne.First);

            Console.WriteLine(EnumTwo.Sixth);

            Months months = Months.January;

            Console.WriteLine(EnumThree.Alpha);
        }
    }
}
