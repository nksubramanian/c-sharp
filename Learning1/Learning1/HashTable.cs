using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class HashTable
    {

        public void HashTablemain()
        {
            Hashtable t = new Hashtable();
            t.Add(1, "Mango");
            t.Add(2, "Orange");
            t.Add(3, "Apple");
            t.Remove(3);

            bool status = t.Contains(1);
            Console.WriteLine(status);

            foreach (DictionaryEntry x in t)
            {
                Console.WriteLine(x.Key);
                Console.WriteLine(x.Value);

            }



        }


    }
}
