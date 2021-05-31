using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class staticconstructor
    {

        public static void staticconstructormain()
        {

            Console.WriteLine(StaticClass.a);
            StaticClass ob1 = new StaticClass(31);
            Console.WriteLine(StaticClass.a);

        }
    }


    class StaticClass
    {
        static StaticClass()
        {
            Console.WriteLine("The static constructor is called");
            a = 4;
            b = 5;

        }

        public StaticClass(int temp)
        {
            a = temp;
        }


        public static int a;
        public static int b;





    }










}
