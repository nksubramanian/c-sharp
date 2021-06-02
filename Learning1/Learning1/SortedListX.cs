using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    public class SortedListX
    {
        public  void SortedListXmain()
        {
            SortedList sort = new SortedList();

            sort.Add(1, "Zara Ali");
            sort.Add(2, "Abida Rehman");
            sort.Add(3, "Joe Holzner");
            sort.Add(4, null);

            foreach (DictionaryEntry item in sort)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(sort[2]);

        }

       


    }

}
