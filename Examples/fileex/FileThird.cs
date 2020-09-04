using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.fileex
{
    class FileThird
    {
        public static void MainMethod(string[] args)
        {
            FileStream f = new FileStream("d:\\b.txt", FileMode.OpenOrCreate);//creating file stream  
            f.WriteByte(65);//writing byte into stream  
            f.Close();//closing stream  
            Console.ReadKey();
        }
    }
}
