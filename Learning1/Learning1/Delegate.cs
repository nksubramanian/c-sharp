using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class Delegate
    {
        public void delegatemain()
        {
            MyClass mc = new MyClass();
            Calculate addition = new Calculate(mc.add);
            Calculate subtract = new Calculate(mc.subtract);
            Console.WriteLine(addition(10, 5));

        }

    }

    public delegate int Calculate(int value1, int value2);

    class MyClass
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int subtract(int a, int b)
        {
            return a - b;
        }

    }


}
