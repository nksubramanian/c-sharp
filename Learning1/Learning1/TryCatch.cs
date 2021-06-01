using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class TryCatch
    {
        public void TryCatchmain()
        {
            try
            {
                string str = "100qwd";
                int s = int.Parse(str);
                int Nr = 5;
                int Dr = 0;
                double num = Nr / Dr;

            }
            /*
            catch
            {
                Console.WriteLine("Catch is executed");

            }*/

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide by zero");
                Console.WriteLine(ex.Message);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format exception");
                Console.WriteLine(ex.Message);

            }

            catch (Exception ex)
            {
                Console.WriteLine("Catch is executed");
                Console.WriteLine(ex.Message);

            }

            finally
            {
                Console.WriteLine("in the finally");

            }



        }
    }
}
