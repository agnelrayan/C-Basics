﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.polymorphismex
{
    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Vow vow");
        }
    }
}
