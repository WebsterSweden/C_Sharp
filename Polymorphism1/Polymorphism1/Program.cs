using System;

namespace Polymorphism1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.AnimalSound();

            Animal dog = new Dog();
            dog.AnimalSound();

            Animal cat = new Cat();
            cat.AnimalSound();
        }
    }
}
