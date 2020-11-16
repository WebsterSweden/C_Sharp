using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism2
{
    public class Animal
    {
        public virtual void AnimalSound()
        {
            //Console.WriteLine("Animal have sound");
            string animalSound = "Animal have sound";
            //return animalSound;
            Console.WriteLine(animalSound);
        }

        public virtual void AnimalSound(string animalNameParameter, string animalBreedParameter)
        {
            string animalName = animalNameParameter;
            string animalBreed = animalBreedParameter;

            //Console.WriteLine("Animal have sound");
            string animalSound = "Animal have sound";
            //return animalSound;
            Console.WriteLine($"{animalName} {animalBreed} {animalSound}");
        }
    }
}
