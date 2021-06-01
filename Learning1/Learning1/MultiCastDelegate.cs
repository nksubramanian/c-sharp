using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    public delegate void DemoDelegate();
    class MultiCastDelegate
    {
        public void MultiCastDelegateMain()
        {
            FunctionsClass ob1 = new FunctionsClass();
            DemoDelegate del1 = new DemoDelegate(ob1.methodOne);

            //Syntactical sugar
            DemoDelegate del2 = ob1.methodTwo;

            del1();
            del2();

            Console.WriteLine("--------------------------------");
            DemoDelegate del3 = del1 + del2;
            del3();
            

            Console.WriteLine("--------------------------------");
            del3 = del3 - del1;
            del3();

        }

    }

    class FunctionsClass
    {
        public void methodOne()
        {
            Console.WriteLine("methodOne is called");
        }
        
        public void methodTwo()
        {
            Console.WriteLine("methodTwo is called");
        }

    }















}
