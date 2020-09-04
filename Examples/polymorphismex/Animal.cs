using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.polymorphismex
{
    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
}
