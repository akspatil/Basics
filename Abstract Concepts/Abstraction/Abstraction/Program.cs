using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1 test1 = new Test1();
            test1.Post();

            //Base class type
            Test1 test11 = new Test3();
            test11.Post();

            //Derived class1 type
            Test2 test2 = new Test3();
            test2.Post();

            //Derived class 2 type
            Test3 test3 = new Test3();
            test3.Post();

            //Base class value : Doesn't work. Cannot be cast down
            //Test3 test = (Test3)new Test1();
            //test.Post();

            Console.ReadLine();
        }
    }
}
