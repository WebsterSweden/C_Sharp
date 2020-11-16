using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism1
{
    class Animal
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
}
