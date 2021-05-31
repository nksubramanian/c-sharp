using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class PrivateConstructor
    {

        public static void PrivateConstructorMain()
        {
            Console.WriteLine(privateconstructor.e);
        }

        
    }


    class privateconstructor
    {
        private privateconstructor()
        {

        }

        public static double e = 2.71;
        public static double pi = 3.14;  


    }
}
