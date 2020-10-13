using System;

namespace Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassOne classOneObjectOne = new ClassOne();
            string classOneStringOneVariable = classOneObjectOne.classOneStringOne;
            Console.WriteLine("classOneStringOneVariable: " + classOneStringOneVariable);

            ClassOne classOneObjectTwo = new ClassOne();
            classOneObjectTwo.classOneStringOne = "classOneObjectTwo.classOneStringOneValue";
            Console.WriteLine(classOneObjectTwo.classOneStringOne);
            classOneObjectTwo.classOneStringTwo = "classOneObjectTwo.classOneStringTwoValue";
            Console.WriteLine(classOneObjectTwo.classOneStringTwo);
            classOneObjectTwo.classOneIntOne = 3;
            Console.WriteLine(classOneObjectTwo.classOneIntOne);

            string classOneStringStaticOne = ClassOne.classOneStringStaticOne;
            Console.WriteLine("classOneStringStaticOne: " + classOneStringStaticOne);
            classOneStringStaticOne = "classOneStringStaticOneValue";
            Console.WriteLine("classOneStringStaticOne: " + classOneStringStaticOne);

            string classOneStringStaticTwo = ClassOne.classOneStringStaticOne;
            classOneStringStaticTwo = "classOneStringStaticTwoValue";
            Console.WriteLine("classOneStringStaticTwo: " + classOneStringStaticTwo);
        }
    }
}
