using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class Conversion
    {
        public void Conversionmain()
        {
            int i = 5;
            float f = i;

            double d = 4.3;
            int j = (int)d;
            int u = Convert.ToInt32(d);

            string str = "100";
            int s = int.Parse(str);

            string str1 = "100";
            int Result = 0;
            bool status = int.TryParse(str1, out Result);

            if (status)
            {
                Console.WriteLine(Result);
                Console.WriteLine("Above is converted");
            }
            else
            {
                Console.WriteLine("Could not convert");
            }
        }

    }


}
