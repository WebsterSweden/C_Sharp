using System;

namespace Constructor2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructor.
            Person personObject = new Person("ConstructorFirst", "ConstructorLast", 64);
            Console.WriteLine(personObject.FirstName + " " + personObject.LastName + " " + personObject.Age);

            // Get Set Property.
            //Person personGetSet = new Person();
            //Console.WriteLine(personGetSet.FirstName = "GetSetFirst");

        }
    }
}
