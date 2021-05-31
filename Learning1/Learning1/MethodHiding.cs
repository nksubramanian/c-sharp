using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class MethodHiding
    {
        public void MethodHidingmain()
        {
            DerivedClass ob = new DerivedClass();
            ob.first_name = "a";
            ob.last_name = "b";
            ob.get_fullname();
            ((BaseClass)ob).get_fullname();



        }


    }


    class BaseClass
    {
        public string first_name;
        public string last_name;



        public void get_fullname()
        {
            Console.WriteLine(first_name + " " + last_name);
        }

    }


    class DerivedClass: BaseClass
    {
        public void get_fullname()
        {
            Console.WriteLine("*****************");
            base.get_fullname();
            Console.WriteLine(first_name + " " + last_name+" derived class");
        }


    }












}
