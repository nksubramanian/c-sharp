
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class ListDemo
    {
        public void ListDemomain()
        {

            IList<int> gg = new List<int>();
            gg.Add(1);
            gg.Add(2);
            gg.Add(3);


            foreach ( var x in gg)
            {
                Console.WriteLine(x);
            }


            

            List<int> bb = new List<int>();
            bb.Add(89);
            bb.AddRange(gg);


            bb.ForEach(element => Console.WriteLine(element));
            Console.WriteLine(bb.Contains(89));
            bb.Remove(89);
            Console.WriteLine(bb.Contains(89));
            Console.WriteLine("*********************");
            Console.WriteLine(bb.TrueForAll(x => x < 100));

        }
    }
}
