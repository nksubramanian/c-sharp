using System;

namespace Learning1
{
    public class LearnEnum 
    {
        enum Weekday
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
        }
        public static void EnumMain()
        {
            Console.WriteLine(Weekday.Monday);
            Console.WriteLine((int)Weekday.Monday);
        }

    }


}
