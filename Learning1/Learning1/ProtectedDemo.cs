using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class ProtectedDemo
    {
        public void ProtectedDemomain()
        {
            Aa ob = new Bb();
            ob.print();
        }

    }



    class Aa
    {
        protected int num = 5;

        public virtual void print()
        {

        }

    }

    class Bb: Aa
    {
        public override void print()
        {
            Bb x = new Bb();
            Console.WriteLine(x.num);
            Console.WriteLine("I am also inherited");
        }
    }


}
