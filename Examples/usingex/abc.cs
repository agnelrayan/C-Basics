using Examples.usingex.space_first;
using Examples.usingex.space_two;
using System;

namespace Examples.usingex
{
    namespace space_first
    {
        class abc
        {
            public void func()
            {
                Console.WriteLine("class ABC...");
            }
        }
    }

    namespace space_two
    {
        class xyz
        {
            public void func()
            {
                Console.WriteLine("class XYZ");
            }
        }
    }

    class TestMain {
        public static void MainMethod(string[] args)
        {
            abc obj = new abc();
            obj.func();
            xyz obj2 = new xyz();
            obj2.func();
            Console.ReadKey();
        }
    }


   
}
