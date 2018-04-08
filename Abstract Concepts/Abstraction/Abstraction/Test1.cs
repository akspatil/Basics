using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Test1
    {
        public virtual void Post()
        {
            Console.WriteLine("Calling from Test1");
        }
    }

    public abstract class Test2 : Test1
    {
        public abstract override void Post();
    }

    public class Test3 : Test2
    {
        public override void Post()
        {
            Console.WriteLine("Calling from Test3");
        }
    }
}
