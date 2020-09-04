using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Examples.samples
{
    class Regexam
    {
        public static bool hasSpecialChar(string input)
        {
            string specialChar = "548110*****df*df8801";
            
            foreach (var item in specialChar)
            {
                if (input.Contains(item)) return true;
            }



            return true;
        }

        public static void MainMethod(string[] args)


        {
            bool res = hasSpecialChar("***");
            Console.WriteLine("hi");
           // Console.WriteLine(res);


            bool result3 = Regex.IsMatch("fdfdafffdfafafafaf", @"[a-zA-Z]{7}$");//^.{50}$
            Console.WriteLine("Result3:" + result3);//548110******8801
            Console.ReadKey();
        }
    }

}