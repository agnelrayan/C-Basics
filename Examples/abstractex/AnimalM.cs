using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.abstractex
{
    class AnimalM
    {
        static void AbstractMainMethod()
        {
            Dog dog = new Dog();
            dog.animalSound();
            dog.sleep();
            Console.ReadKey();


        }
    }
}
