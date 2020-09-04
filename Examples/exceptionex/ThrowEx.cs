using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.exceptionex
{
    class ThrowEx
    {

        public static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied");
            }
            else
            {
                Console.WriteLine("Access Granted");
            }
        }
        public static void MainMethod(string[] args)
        {
            checkAge(15);
            Console.ReadKey();
        }

        
    }
}
