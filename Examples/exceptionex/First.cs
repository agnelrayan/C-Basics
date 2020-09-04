using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.exceptionex
{
    class First
    {
        static void MainMethod(string[] args)
        {
           

            try
            {

                int a = 5;
                int b = 0;
                Console.WriteLine(a / b);

                string str = null;
                Console.WriteLine(str.Length);

                int[] myNum = { 1, 2, 3 };
                Console.WriteLine(myNum[10]);

            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Divide by zero");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            finally
            {
                Console.WriteLine("Finally Block is executed...");
            }

            Console.ReadKey();
        }
       
        
    }
}