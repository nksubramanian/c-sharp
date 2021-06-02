using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class dynamictype
    {
        public void dynamictypemain()
        {
            dynamic dynamicvar = 100;
            Console.WriteLine(dynamicvar);
            Console.WriteLine(dynamicvar.GetType().ToString());
            dynamicvar = "abcdefg";
            Console.WriteLine(dynamicvar);
            Console.WriteLine(dynamicvar.GetType().ToString());
            print(12324);
            print("abcdef");



        }
        
        public static void print(dynamic x)
        {
            Console.WriteLine(x);
        }

    }
}
