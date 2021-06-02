using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class NamedParameter
    {

        public void NamedParametermain()
        {
            Demo1 xx = new Demo1();
            xx.print();
            xx.print(5);
            xx.print1(i:8, d: 2.3);
        }
    }


    class Demo1
    {
        public void print(int i =7)
        {
            Console.WriteLine(i);
        }

        public void print1(double d, int i)
        {
            Console.WriteLine("success");
        }

    }



}
