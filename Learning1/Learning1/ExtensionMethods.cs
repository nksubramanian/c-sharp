using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class ExtensionMethods
    {
        public void ExtensionMethodsmain()
        {
            string d = "a b c";
            Console.WriteLine(d.stringwithdollar());
            Console.WriteLine(d.stringwithnum("ads"));

        }

    }

    public static class Mem
    {
        public static string stringwithdollar(this string x)
        {
            return "$"+x;
        }


        public static string stringwithnum(this string x, string c)
        {
            return c + x;
        }
    }


}
