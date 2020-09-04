using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.fileex
{
    class MultipleBytes
    {
 
        public static void MainMethod(string[] args)
        {
            FileStream f = new FileStream("d:\\fileex\\c.txt", FileMode.Append);
            
            for (int i = 65; i <= 90; i++)
            {
                f.WriteByte((byte)i);
            }

            f.Close();
            Console.WriteLine("It is written successfully");

            FileStream f2 = new FileStream("d:\\fileex\\c.txt", FileMode.OpenOrCreate);
            int j = 0;
            while ((j = f2.ReadByte()) != -1)
            {
                Console.Write((char)j);
            }

            f2.Close();

           

            Console.ReadKey();
           
        }
    }
}

