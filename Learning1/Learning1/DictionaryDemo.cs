using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class DictionaryDemo
    {
        public void DictionaryDemomain()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "a");
            dict.Add(2, "b");
            dict.Add(3, "c");
            dict.Add(4, "d");
            dict.Remove(4);
            bool s = dict.ContainsKey(3);

            Console.WriteLine(s);
            Console.WriteLine(dict.ContainsValue("c"));
            foreach (KeyValuePair<int,string>element in dict)
            {
                Console.WriteLine(element.Key);
                Console.WriteLine(element.Value);
            }

        }
    }
}
