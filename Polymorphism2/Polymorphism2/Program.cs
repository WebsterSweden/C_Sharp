using System;

namespace Polymorphism2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.AnimalSound();
            animal.AnimalSound("AnimalNameArgument", "AnimalBreedArgument");

            Animal dog = new Dog();
            dog.AnimalSound();
            dog.AnimalSound("DogNameArgument", "DogBreedArgument");

            Animal cat = new Cat();
            cat.AnimalSound();
            cat.AnimalSound("CatNameArgument", "CatBreedArgument");
        }
    }
}
