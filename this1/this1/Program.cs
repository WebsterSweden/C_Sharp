using System;

namespace this1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personOne = new Person("PersonOne", 36);
            Person personTwo = new Person("PersonTwo", 48);

            Console.WriteLine($"{personOne.Name} : {personOne.Age}");
            Console.WriteLine($"{personTwo.Name} : {personTwo.Age}");

            Console.WriteLine($"{personOne.}");
        }
    }
}
