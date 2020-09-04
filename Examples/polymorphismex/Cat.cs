using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.polymorphismex
{
    class Cat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Meow Meow");
        }
    }
}
