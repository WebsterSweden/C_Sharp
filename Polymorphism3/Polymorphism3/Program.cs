using System;

namespace Polymorphism3
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent();
            Console.WriteLine(parent.ParentStringOne);

            Child child = new Child();
            Console.WriteLine(child.ParentStringOne);

            Parent parentChild = new Child();
            Console.WriteLine(parentChild.ParentStringOne);
        }
    }
}
