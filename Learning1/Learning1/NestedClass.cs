using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class NestedClass
    {
        public void NestedClassmain()
        {

            Outer oo = new Outer();
            oo.outer_func();
            //oo.inner_func(); outer class object cannnot inner class methods

            Outer.Inner oi = new Outer.Inner();
            oi.inner_func(oo);


        }
    }



    class Outer
    {
        public void outer_func()
        {
            Console.WriteLine("outer_func");
        }

        private void Test()
        { 

        }


        public class Inner
        {
            public void inner_func(Outer outer)
            {
                outer.Test();
                Console.WriteLine("inner_func, I am not accessible by the objects of the outer class");
            }
        }



    }






}
