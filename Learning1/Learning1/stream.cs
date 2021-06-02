using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class stream
    {

        public void streammain()
        {

            writestream();
            readstream();


        }


        public static void writestream()
        {
            StreamWriter writer = new StreamWriter(@"D:\Subbu\LearningCsharp\Learning1\Learning1\Demo.txt");
            writer.WriteLine("Hello World");
            writer.Close();
        }

        public static void readstream()
        {

           StreamReader reader = new StreamReader(@"D:\Subbu\LearningCsharp\Learning1\Learning1\Demo.txt");
           Console.WriteLine(reader.ReadToEnd());
           reader.Close();

        }





    }
}
