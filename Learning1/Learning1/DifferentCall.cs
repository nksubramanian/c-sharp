using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class DifferentCall
    {
        public void DifferentCallmain()
        {
            Modifier temp = new Modifier();
            int a = 4;
            int b = 5;
            Console.WriteLine("Call by value");
            Console.WriteLine("a={0} and b={1}", a, b);
            temp.swap(a, b);
            Console.WriteLine("a={0} and b={1}", a, b);
            Console.WriteLine("Below is call by reference");
            Temp x = new Temp(3, 4);
            x.print_state();
            temp.swapbyref(x);
            x.print_state();
            Console.WriteLine("Call by ref second method");
            Console.WriteLine("a={0} and b={1}", a, b);
            temp.swapbyref1(ref a, ref b);
            Console.WriteLine("a={0} and b={1}", a, b);




        }
    }


    class Temp
    {
        public int a;
        public int b;

        public Temp(int a, int b)
        {
            this.a = a;
            this.b = b;
        }


        public void print_state()
        {
            Console.WriteLine("a={0} and b ={1}", a, b);
        }
    }

    class Modifier
    {
        public void swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public void swapbyref(Temp temp)
        {
            int v = temp.a;
            temp.a = temp.b;
            temp.b = v;
        }

        public void swapbyref1(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

        }

    }


}















