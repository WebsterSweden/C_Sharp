using System;

namespace Method1
{
    public class ClassThree
    {
        public static string classThreeString = "classThreeString";

        public static string classThreeMethodOne(string parameter)
        {
            string classThreeMethodOneVariable = parameter;
            return classThreeMethodOneVariable;
        }
    }

    class ClassFour
    {
        public void ClassFourMethodOne()
        {
            Console.WriteLine("ClassFourMethodOne");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Local function can be made static.
            void MainMethodOne()
            {
                Console.WriteLine("MainMethodOne");
            }

            MainMethodOne();

            static void MainMethodTwo()
            {
                Console.WriteLine("MainMethodTwo");
            }

            MainMethodTwo();

            Console.WriteLine(ClassOne.classOneString);

            Console.WriteLine(ClassOne.ClassOneMethodOne());

            var classTwoObject = new ClassTwo();
            Console.WriteLine(classTwoObject.ClassTwoString);
            Console.WriteLine(classTwoObject.ClassTwoMethodOne("argument"));

            Console.WriteLine(ClassThree.classThreeMethodOne("argument"));

            var classFourObject = new ClassFour();
            Console.WriteLine(classFourObject);
            classFourObject.ClassFourMethodOne();
        }
    }
}
