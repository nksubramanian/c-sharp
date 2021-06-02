using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class AnonymousMethods
    {

        public delegate int Operation(int num);

        public void AnonymousMethodsmain()
        {

            Operation increment = delegate (int num) { return ++num; };


            Console.WriteLine(increment(5));



        }
    }




}
