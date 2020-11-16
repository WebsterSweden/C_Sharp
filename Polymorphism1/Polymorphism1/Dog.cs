using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism1
{
    class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The dog says woof!");
        }
    }
}
