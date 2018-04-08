using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualSample
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            DerivedClass dc = new DerivedClass();
            BaseClass bcdc = new DerivedClass();

            bc.TestMethod();
            bc.TestMethod2();

            dc.TestMethod();
            dc.TestMethod2();

            bcdc.TestMethod2();
            bcdc.TestMethod();

            Console.ReadLine();
        }
    }
}
