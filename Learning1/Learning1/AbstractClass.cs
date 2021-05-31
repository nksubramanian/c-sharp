using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class AbstractClass
    {
        public void abstractclass()
        {
            Ab1 x = new deri();
            x.print();
            x.func();


        }
    }


    public abstract class Ab1
    {
        public void print()
        {
            Console.WriteLine("I am being implement");
        }

        public abstract void func();
    }



    class deri : Ab1
    {
        public override void func()
        {
            Console.WriteLine("now I am implemented");
        }
    }

}

