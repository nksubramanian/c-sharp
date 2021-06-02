using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class GenericsDemo
    {
        public void GenericsDemoMain()
        {
            Comparator.compare(4, 4);
            Comparator.compare("4", "4");
            Comparator.compare("sacac", 4);

            Console.WriteLine("--------------------------------");

            Comparator.compare_generics<int>(4, 4);
            Comparator.compare_generics("4", "4");
            Comparator.compare_generics("4", "43");
            //Comparator.compare_generics("sacac", 4);

            Console.WriteLine("--------------------------------");

            GenericsComparator<int>.compare_generics(4, 3);



        }

    }


    class Comparator
    {
        public static void compare(object a, object b)
        {
            Console.WriteLine(a == b);
        }

        public static void compare_generics<T>(T a, T b)
        {
            Console.WriteLine(a.Equals(b));
        }


    }

    class GenericsComparator<T>
    {

        public static void compare_generics(T a, T b)
        {
            Console.WriteLine(a.Equals(b));
        }


    }







}
