﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class Interface
    {

        public void Interfacemain()
        {
            xyz t = new xyz();
            t.print2();

        }
    }


    interface skeleton
    {
        void print();
        string name();
    }

    interface skeleton2
    {
        void print2();
    
    }



    class xyz: skeleton, skeleton2
    {
        public void print()
        {
            Console.WriteLine("in the print function");
        }

        public string name()
        {
            return "xyz";
        }

        public void print2()
        {
          Console.WriteLine("in the second print function");
        }
    }











}
