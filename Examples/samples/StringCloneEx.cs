using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.samples
{
    class StringCloneEx
    {
        public static void MainMethod(string[] args)
        {
            string s1 = "Scope of Supply for Q-009655-A";
            string s2 = "Q-009655-A-0";
            string s3 = s1.Substring(20);
            string s4 = s2.TrimEnd();
            Console.WriteLine("s1:"+s1);
            Console.WriteLine("s2:"+s2);
            Console.WriteLine("s3:"+s3);
            Console.WriteLine("s4:"+s4);
            if (s2.Equals(s3))
            {
                Console.WriteLine("Scope of supply is same as Quote Number");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
            // Console.WriteLine(s2);
            // Console.WriteLine(s2.GetHashCode());
            Console.ReadKey();

        }
    }
}
