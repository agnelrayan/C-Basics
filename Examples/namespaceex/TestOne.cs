using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.namespaceex
{
    class TestOne
    {
        public TestOne()
        {
            System.Console.WriteLine("Welcome to C Sharp");
        }
    }
    class MyClient {
        public void ClientDisplayOne()
        {
            TestOne test = new TestOne();
            Console.WriteLine("hi helo");
           // Console.ReadKey();
            
        }
    }

}

namespace Examples.namespaceextwo
{
    class MyClient {
        public void MyClientDisplayTwo()
        {
            Console.WriteLine("hi helo two two");
           // Console.ReadKey();
        }
    }

}
class Client {
public static void MainMethod(string[] args)
    {
        Examples.namespaceex.MyClient obj = new Examples.namespaceex.MyClient();
        Examples.namespaceextwo.MyClient obj2 = new Examples.namespaceextwo.MyClient();

        obj.ClientDisplayOne();
        obj2.MyClientDisplayTwo();
        Console.ReadKey();

    }
}

