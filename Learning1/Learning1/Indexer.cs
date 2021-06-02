using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class Indexer
    {

        public void indexermain()
        {
            EmployeeI xc = new EmployeeI();
            xc[0] = "a";
            xc[1] = "b";
            xc[2] = "c";

            Console.WriteLine(xc[0] + xc[1] + xc[2]);

        }

    }

    class EmployeeI
    {
        private string[] data = new string[5];

        public string this[int index]
        {
            get
            {
                return data[index];
            }

            set
            {
                data[index] = value;
            }
        }
    }
}
