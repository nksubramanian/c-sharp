using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class Overriding
    {
        public void Overridingmain()
        {
            baseC ob = new DerivedC();
            ob.func();
            baseC obj = new baseC();
            obj.func();
        }


    }



    class baseC
    {
        public virtual void func()
        {
            Console.WriteLine("base class");
        }
    }

    class DerivedC:baseC
    {
        public override void func()
        {
            Console.WriteLine("derived class");
        }
    }


}
