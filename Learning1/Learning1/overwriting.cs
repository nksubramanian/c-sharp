using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class overwriting
    {
        public void overwritingmain()
        {
            A1 obj = new A1();
            A1.function();
            A1.function(5);
            A1.function(5.3);
            int a = 5;
            A1.function(ref a);
            A1.function(out a);


        }
    }


    class A1
    {
        public static void function()
        {
            Console.WriteLine("no parameters");
        }

        public static void function(int a)
        {
            Console.WriteLine("one parameter with int");
        }
        public static void function(double a)
        {
            Console.WriteLine("one parameter with double");
        }
        public static void function(ref int a)
        {
            Console.WriteLine("one parameter ref int");
        }
        public static void function(out int a)
        {
            Console.WriteLine("one parameter ref int");
        }


    }



}
