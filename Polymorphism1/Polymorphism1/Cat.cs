using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism1
{
    class Cat : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The cat says meow!");
        }
    }
}
