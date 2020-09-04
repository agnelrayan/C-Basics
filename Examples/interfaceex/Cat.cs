using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.interfaceex
{
    class Cat : Animal
    {
        public void animalSound()
        {
            Console.WriteLine("Meow Meow...");
        }

        public void run()
        {
            throw new NotImplementedException();
        }
    }
}
