using System;
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
            skeleton w = new abc();
            w.print();
            

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

    class abc : skeleton
    {
        public void print()
        {
            Console.WriteLine("interface can point to derived class object");
        }

        public string name()
        {
            return "xyz";
        }

    }










}
