using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.samples
{
    class EnumEx
    {
        enum Months {
            January, Februrary,March,April,May,June
        }

        static void EnumExMainMethod()
        {
            int month = (int)Months.April;

            Console.WriteLine(month);
            Console.ReadKey();
        }

       
    }
}
