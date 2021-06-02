using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class AnonymousType
    {

        public void AnonymousTypemain()
        {
            var anonymousdemo = new { name = "Java", marks = 45 };
            Console.WriteLine(anonymousdemo.name);
            Console.WriteLine(anonymousdemo.marks);
            Console.WriteLine(anonymousdemo.name.GetType().ToString());
            Console.WriteLine(anonymousdemo.marks.GetType().ToString());

            var anony2 = new { a = 1, c = new { marks1 = 1, marks2 = 2 } };
            Console.WriteLine(anony2.c.marks1);
            Console.WriteLine("------------------------------------------------------");
            printer(anony2);
        }


        public static void printer(dynamic d)
        {
            Console.WriteLine(d);
        }



    }





}
