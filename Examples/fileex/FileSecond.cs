using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.fileex
{
    class FileSecond
    {
       
        public void WriteMethod()
        {
            FileStream f = new FileStream("D:\\fileex\\output.txt", FileMode.Append);

            StreamWriter s = new StreamWriter(f);

            s.WriteLine("Welcome to File Handling...");
            
            s.Close();
            f.Close();
            Console.WriteLine("File created successfully...");
        }

        public void ReadMethod()
        {
            FileStream f2 = new FileStream("D:\\fileex\\output.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(f2);
            // int j = 0;
            //string j;
            //while ((j=sr.ReadLine())
            //{
            //    Console.Write(j);
            //}
            string line;
            // Read line by line  
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            //string line = sr.ReadLine();
            //Console.WriteLine(line);
            f2.Close();
        }
       
        // Main Method 
        static void MainMethod(string[] args)
        {
            FileSecond obj = new FileSecond();
            obj.WriteMethod();
            obj.ReadMethod();
            Console.ReadKey();
        }
    }
}

