using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Learning1
{
    class AsynchronousProgramming
    {

        public void AsynchronousProgrammingmain()
        {
            Calculate();
            Console.ReadLine();

        }

        public static void Calculate()
        {
            Calculate1();
            Calculate2();
            Calculate3();

            Console.WriteLine("-----------------------------------");

            Task.Run(() => { Calculate1(); });
            Task.Run(() => { Calculate2(); });
            Task.Run(() => { Calculate3(); });


            Console.WriteLine("-----------------------------------");

            var task1 = Task.Run(() => { return Calculate1(); });
            var task2 = Task.Run(() => { return Calculate2(); }); 
            Task.WaitAll(task1, task2);

            var awaiter1 = task1.GetAwaiter();
            var awaiter2 = task2.GetAwaiter();
            var result1 = awaiter1.GetResult();
            var result2 = awaiter2.GetResult();

            Calculate4(result1, result2);

            Console.WriteLine("-----------------------------------aaaaaaaa");
            var taskx = Task.Run(() => { return Calculatex(); });
            var awaiterb = taskx.GetAwaiter();
            awaiterb.OnCompleted(() => 
            { var resultx = awaiterb.GetResult();
              CalculateDouble(resultx);
            });


        }

        public static int Calculate1()
        {
            Thread.Sleep(100);
            Console.WriteLine("Calculating result1");
            return 100;

        }


        public static int Calculate2()
        {

            Console.WriteLine("Calculating result2");
            return 100;

        }

        public static int Calculate3()
        {


            Console.WriteLine("Calculating result3");
            return 100;

        }

        public static int Calculate4(int result1, int result2)
        {


            Console.WriteLine("Calculating result4" + (result1 + result2));
            return result1+result2;

        }

        public static int Calculatex()
        {
            Thread.Sleep(100);
            Console.WriteLine("Calculating result1");
            return 100;

        }


        public static int CalculateDouble(int res)
        {
            Console.WriteLine(2*res);
            return 2*res;

        }



    }
}
