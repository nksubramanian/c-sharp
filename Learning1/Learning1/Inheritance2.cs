using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class Inheritance2
    {
        public void Inheritance2main()
        {
            ChildClass ob = new ChildClass();
        }

    }

    class ParentClass
    {
        string name;
        public ParentClass()
        {
            Console.WriteLine("This is base class without parameters");
        }

        public ParentClass(string name)
        {
            this.name = name;
            Console.WriteLine("This is base class with parameters");
        }

    }


    class ChildClass: ParentClass
    {
        public ChildClass() : base("why should I pass the string here?")
        {
            Console.WriteLine("This is derived class");
        }

    }


}
