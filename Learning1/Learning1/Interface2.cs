using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class Interface2
    {
        public void interface2main()
        {
            ii x = new ii();
            ((i1)x).print();
            i2 y = new ii();
            y.print();
        }

    }


    interface i1
    {
        void print();
    }


    interface i2
    {
        void print();
    }

    class ii : i1, i2
    {
        void i1.print()
        {
            Console.WriteLine("i1");
        }

        void i2.print()
        {
            Console.WriteLine("i2");
        }
    }


}
