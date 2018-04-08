using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualSample
{
    public class BaseClass
    {
       public virtual void TestMethod()
        {
            Console.WriteLine("Inside Base Class");
        }

        public void TestMethod2()
        {
            Console.WriteLine("Inside Base class on Method2");
        }
    }
}
