using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.exceptionex
{
    class ExceptionEx
    {
        public static void MainMethod(string[] args)
        {
            Console.WriteLine("Welcome to EH..1");
            Console.WriteLine("Welcome to EH..2");
            Console.WriteLine("Welcome to EH..3");
            Console.WriteLine("Welcome to EH..4");

            try
            {
                int[] ar = { 10, 20, 30 };
                Console.WriteLine(ar[5]);

                string str = null;
                Console.WriteLine(str.Length);

                int a = 5;
                int b = 0;


                Console.WriteLine(a / b);
            }
          
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of Range Exception");
            }

            catch (NullReferenceException)
            {
                Console.WriteLine("Null Reference Exception...");
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide by zero Exception...");
            }

            catch (Exception)
            {
                Console.WriteLine("Parent Exception...");
            }

            finally
            {
                Console.WriteLine("It always Executed....");
            }


            Console.WriteLine("Welcome to EH.5");
            Console.WriteLine("Welcome to EH..6");
            Console.WriteLine("Welcome to EH..7");
            Console.WriteLine("Welcome to EH..8");

            Console.ReadKey();

            // o/p : 

        }
    }
}
