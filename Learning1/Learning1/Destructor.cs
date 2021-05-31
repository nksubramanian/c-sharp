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
            A ob = new A();


        }


    }


    class A
    {
        public A()
        {
            Console.WriteLine("constructor is called");
        }

        ~A()
        {
            Console.WriteLine("Destructor is called");
        }

    }





















}
