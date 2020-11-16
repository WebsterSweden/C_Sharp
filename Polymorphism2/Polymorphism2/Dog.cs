using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism2
{
    class Dog : Animal
    {
        public override void AnimalSound()
        {
            //Console.WriteLine("The dog says woof!");
            string dogSound = "The dog says woof!";
            //return dogSound;
            Console.WriteLine(dogSound);
        }

        public override void AnimalSound(string animalNameParameter, string animalBreedParameter)
        {
            string dogName = animalNameParameter;
            string dogBreed = animalBreedParameter;

            //Console.WriteLine("The dog says woof!");
            string dogSound = "The dog says woof!";
            //return dogSound;
            Console.WriteLine($"{dogName} {dogBreed} {dogSound}");
        }
    }
}
