using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class ObjectInitializer
    {

        public void ObjectIntializermain()
        {
            EmployeeO ooo = new EmployeeO() { id = 34, name = "abc" };
            Console.WriteLine(ooo.id);
            Console.WriteLine(ooo.name);

        }

    }

    class EmployeeO
    {
        public int id;
        public string name;
    }
}
