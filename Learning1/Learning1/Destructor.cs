using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class Destructor
    {
        public void DestructorMain()
        {
            destructor_demonstrate();

        }


        public void destructor_demonstrate()
        {
            for (int i = 0; i < 256 * 256; i++)
            {
                A ob = new A();
            }
        }
    }


    class A
    {
        int[] array;

        public A()
        {
            //Console.WriteLine("constructor is called");
            array = new int[128 * 128];
        }

        ~A()
        {
            Console.WriteLine("Destructor is called");
        }

    }





















}
