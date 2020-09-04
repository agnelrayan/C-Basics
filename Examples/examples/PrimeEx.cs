using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.examples
{
    class PrimeEx
    {
        public static void MainMethod(string[] arg)
        {

            int n = 15; 
            int m = 0;
            m = n / 2; //7
            bool flag = false;
            for (int i=2;i<=m;i++) //m=7 
            {

                if (n%i==0) //n=15 ,1
                {
                    Console.WriteLine("Number is not Prime");
                    flag = true;
                    break;
                }

            }

            if (!flag)
                Console.WriteLine("Is Prime");

            Console.ReadKey();
        }

    }
}
