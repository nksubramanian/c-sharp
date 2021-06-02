using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Learning1
{
    class asyncandawait
    {
        public void asyncandawaitmain()
        {

            method1();
            for(int i =0;i<20;++i)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }



        public static async void method1()
        {
            int value = await method2();
            Console.WriteLine("output:" + value);

        }

        public static Task<int> method2()
        {
            return Task.Run(() => { Thread.Sleep(5000); return 1; });
        }










    }
}
