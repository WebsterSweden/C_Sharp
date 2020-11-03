using System;

namespace Object1
{
    class ClassOne
    {
        public string ClassOnePropertyOne { get; set; } = "ClassOnePropertyOne";

        public string ClassOnePropertyOneMethod(string parameterOne)
        {
            string classOnePropertyOneMethodVariable = parameterOne;
            return classOnePropertyOneMethodVariable;
        }
    }

    class ClassTwo : ClassOne
    {
        string ClassTwoPropertyOneMethod(string parameterOne)
        {
            string classTwoPropertyOneMethodVariable = parameterOne;
            return classTwoPropertyOneMethodVariable;
        }

        ClassOne classOne = new ClassOne();
    }

    class Program
    {
        static void Main(string[] args)
        {
            ClassOne classOnePropertyOneObject = new ClassOne();

            classOnePropertyOneObject.ClassOnePropertyOne = "ClassOnePropertyOneMain";

            Console.WriteLine(classOnePropertyOneObject.ClassOnePropertyOne);

            Console.WriteLine(classOnePropertyOneObject.ClassOnePropertyOneMethod("ClassOnePropertyOneMain"));
        }
    }
}
