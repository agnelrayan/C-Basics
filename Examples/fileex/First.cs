using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.fileex
{
    class First
    {
        static void MainMethod(string[] args)
        {
            string text = "welcome to file";
            File.WriteAllText("abc.txt",text);

            string readText = File.ReadAllText("abc.txt");
            Console.WriteLine(readText);
            Console.ReadKey();

            //using (TextWriter writer = File.CreateText("e:\\f.txt"))
            //{
            //    writer.WriteLine("Hello C#");
            //    writer.WriteLine("C# File Handling");
            //}
            //Console.WriteLine("Data written successfully...");

        }
    }
}
