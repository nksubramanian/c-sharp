using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    public delegate int DemoDelegate1(out int variable);
    class MultiDelegateReturn
    {
        public void MultiDelegateReturnmain()
        {
            TempClass objectx = new TempClass();
            DemoDelegate1 h;
            h = objectx.methodOne;
            h += objectx.methodTwo;
            int g = 5;
            Console.WriteLine(h(out g));

        }
    }


    class TempClass
    {
        public int methodOne(out int variable)
        {
            variable = 10;
            return 10;
        }

        public int methodTwo(out int variable)
        {
            variable = 20;
            return 20;
        }

    }

}
