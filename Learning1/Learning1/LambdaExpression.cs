using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class LambdaExpression
    {
        public delegate int operations(int num);
        public void LambdaExpressionMain()
        {
            var a = -1;
            operations decrement = num => a + num;

            Console.WriteLine(decrement(4));

        }
    }

}
