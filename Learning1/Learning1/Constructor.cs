using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class Constructor
    {
        public static void ConstructorMain()
        {
            CopyConstructor ob = new CopyConstructor(3, 4);
            ob.get_state();
            CopyConstructor ob1 = new CopyConstructor(3, 4);
            ob1.get_state();
        }


    }


    class CopyConstructor
    {
        public int a;
        public int b;

        public CopyConstructor(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void get_state()
        {
            Console.WriteLine("The value of a is {0} and the value of b is {1}", this.a, this.b);
        }

        public CopyConstructor(CopyConstructor ob)
        {
            this.a = ob.a;
            this.b = ob.b;

        }

    }




}
