using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.samples
{
    class TypeConversionEx
    {
        public static void MainMethod(string[] args)
        {

            int i = 100;
            double d = i;
            Console.WriteLine(d);

            double d2 = 434.343;
            int i2 = (int)d2;

            Console.WriteLine("I2 is: "+i2);
           

            int i3 = 12;
            string s = i3.ToString();

            

            Console.WriteLine("S is:" + s);
            Console.WriteLine("After Converting: "+Convert.ToDouble(i3));
            Console.ReadKey();

        }
    }
}
