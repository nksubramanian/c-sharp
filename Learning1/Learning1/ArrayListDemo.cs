using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class ArrayListDemo
    {

        public void ArrayListDemomain()
        {
            ArrayList a1 = new ArrayList();
            a1.Add(1);
            a1.Add("string");
            var x1 = (int)a1[0];
            var x2 = (string)a1[1];
            Console.WriteLine(x1);
            Console.WriteLine(x2);

            a1.Insert(1, "Hello World");
            foreach (var iter in a1)
            {
                Console.WriteLine(iter);
            }


            a1.Remove(1);
            a1.Reverse();
            foreach (var iter in a1)
            {
                Console.WriteLine(iter);
            }

            a1.Clear();

            foreach (var iter in a1)
            {
                Console.WriteLine(iter);
            }



        }
    }










}
