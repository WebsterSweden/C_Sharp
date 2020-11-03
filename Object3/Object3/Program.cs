using System;

namespace Object3
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassOne objectOne = new ClassOne();
            objectOne.StringOne = "StringOne";
            objectOne.StringTwo = "StringTwo";
            Console.WriteLine(objectOne);

            ClassOne objectTwo = new ClassOne();
            objectTwo.StringOne = "StringOne";
            objectTwo.StringTwo = "StringTwo";
            Console.WriteLine($"{objectTwo.StringOne} {objectTwo.StringTwo}");

            Console.WriteLine("----------");

            ClassTwo objectThree = new ClassTwo();
            objectThree.ClassTwoMethod(objectOne);
            Console.WriteLine($"{objectThree.ClassOneObject.StringOne} {objectThree.ClassOneObject.StringTwo}");
        }
    }
}
