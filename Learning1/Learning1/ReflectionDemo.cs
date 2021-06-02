using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class ReflectionDemo
    {
        public void ReflectionDemoMain()
        {
            EmployeeY cv = new EmployeeY();
            Type T = Type.GetType("Learning1.EmployeeY");
            Console.WriteLine(T.FullName);
            Console.WriteLine(T.Name);
            Console.WriteLine(T.Namespace);

            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name+" "+ property.Name);
            }

            Console.WriteLine("--------------------------------------------------------------");
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.Name);
                Console.WriteLine(constructor.Name.ToString());
            }


            Console.WriteLine("--------------------------------------------------------------");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }

        }

    }


    class EmployeeY
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public EmployeeY(int id, string Name)
        {
            this.Id = id;
            this.Name = Name;
        }

        public EmployeeY()
        {
            this.Id = -1;
            this.Name = "x";
        }

        public void Print()
        {
            Console.WriteLine(Id);
        }
    }
 
    








}
