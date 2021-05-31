using System;

namespace Learning1
{
    class Program
    {

        enum Weekday
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Weekday.Monday);
            Console.WriteLine((int)Weekday.Monday);
        }
    }
}
