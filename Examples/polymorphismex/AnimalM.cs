using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.polymorphismex
{
    class AnimalM
    {
        public void AnimalMainMethod()
        {
            Animal animal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            animal.animalSound();
            dog.animalSound();
            cat.animalSound();

            Console.ReadKey();


        }
    }
}
