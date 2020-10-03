using System;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classOneObject = new ClassOne();
            Console.WriteLine(classOneObject.classOneString);

            Console.WriteLine(ClassOne.classOneStaticString);

            Console.WriteLine(classOneObject.ClassOneMethodOne("classOneMethodOneArgument"));

            Console.WriteLine(classOneObject.ClassOneMethodTwoInstantiateClassTwo());

            var classTwoObject = new ClassTwo();
            Console.WriteLine(classTwoObject.classTwoString);

            Console.WriteLine(ClassTwo.classTwoStaticString);

            Console.WriteLine(classTwoObject.ClassTwoMethodOne("classTwoMethodOneArument"));

            Console.WriteLine(classTwoObject.ClassTwoMethodTwoInstantiateClassOne());

        }
    }
}
