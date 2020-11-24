using System;

namespace Interface1
{
    interface IinterfaceOne
    {
        //string stringFieldOne = "stringFieldOne";

        //public string stringPropertyOne { get; set; } = "stringPropertyOne";
        //public string stringPropertyOne { get; set; }

        //IinterfaceOne() { }

        //void MethodOne()
        //{
        //    Console.WriteLine("MethodOne");
        //}

        void MethodNoBody();
    }

    class ClassOne : IinterfaceOne
    {
        public void MethodNoBody()
        {
            Console.WriteLine("ClassOne : IinterfaceOne");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //interface IinterfaceOne { }

            ClassOne classOne = new ClassOne();

            classOne.MethodNoBody();
        }
    }
}
