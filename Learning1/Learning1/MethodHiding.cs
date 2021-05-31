﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class MethodHiding
    {
        public void Overridingmain()
        {
            DerivedClass ob = new DerivedClass();
            ob.first_name = "a";
            ob.last_name = "b";
            ob.get_fullname();

            BaseClass obb = ob;
            obb.get_fullname();

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
        public new void get_fullname()
        {
            Console.WriteLine(first_name + " " + last_name+" derived class");
        }


    }












}
