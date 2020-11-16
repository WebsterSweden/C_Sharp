using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism2
{
    class Cat : Animal
    {
        public override void AnimalSound()
        {
            //Console.WriteLine("The cat says meow!");
            string catSound = "The cat says meow!";
            //return catSound;
            Console.WriteLine(catSound);
        }

        public override void AnimalSound(string animalNameParameter, string animalBreedParameter)
        {
            string catName = animalNameParameter;
            string catBreed = animalBreedParameter;

            //Console.WriteLine("The cat says meow!");
            string catSound = "The cat says meow!";
            //return catSound;
            Console.WriteLine($"{catName} {catBreed} {catSound}");
        }
    }
}
