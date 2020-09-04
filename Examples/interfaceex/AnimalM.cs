using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.interfaceex
{
    class AnimalM
    {
        static void interfacemainmethod()
        {
            Cat cat = new Cat();
            cat.animalSound();
            Console.ReadKey();

        }
    }
}
