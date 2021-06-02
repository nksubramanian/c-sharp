using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class IndexerOverloading
    {
        public void IndexerOverloadingmain()
        {
            EmployeeZ zc = new EmployeeZ();
            zc[0] = "a";
            zc[1] = "b";
            zc[2] = "c";
            zc[3, "name"] = "d";
            Console.WriteLine(zc[0] + zc[1] + zc[2] + zc[3, "name"]);

        }
    }


    class EmployeeZ
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


        public string this[int index, string name]
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
