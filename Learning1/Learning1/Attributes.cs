using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class Attributes
    {
        public void Attributesmain()
        {
            AttributeDemo x1 = new AttributeDemo();
            List<int> nos = new List<int> { 1, 2, 3 };
            x1.add(nos);
            x1.add(1, 2);
            

        }

        class AttributeDemo
        {
            [Obsolete("add(List<int> Numbers)")]
            public void add(int a, int b)
            {
                Console.WriteLine(a + b);
            }

            public void add(List<int> Numbers)
            {
                int sum = 0;
                foreach (int Num in Numbers)
                {
                    sum += Num;
                }
                Console.WriteLine(sum);

            }


        }


    }
}
