using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualSample
{
    public class DerivedClass : BaseClass
    {
        public new void TestMethod2()
        {
            Console.WriteLine("Inside derived class");
        }

        public override void TestMethod()
        {
            Console.WriteLine("Inside derived class on Method 1 override");
        }
    }
}
