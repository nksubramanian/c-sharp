using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class QuerySyntax
    {
        public void QuerySyntaxmain()
        {

            int[] numbers = { 1, 2, 3, 4, 5, 6 };

            var number = from n in numbers
                         where n % 2 == 0
                         select n;


            foreach (var num in number)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("***********************************");

            var nummethod = numbers.Where(x => (x % 2 == 0)).OrderBy(x=>x);

            foreach (var num1 in nummethod)
            {
                Console.WriteLine(num1);
            }

        }



        

    }





}
