using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class Inheritance1
    {
        public void Inheritance1main()
        {
            PartTimeEmployee ob = new PartTimeEmployee("x","y", 5);
            ob.print_fullname();


        }

    }


    class Employee
    {
        public string first_name;
        public string second_name;


        public void print_fullname()
        {
            Console.WriteLine(first_name + " "+ second_name);
        }

        /*
        public Employee(string first_name, string second_name)
        {
            this.first_name = first_name;
            this.second_name = second_name;
        }*/
    }

    class PartTimeEmployee: Employee
    {
        public int salary;
        public PartTimeEmployee(string first_name, string second_name, int salary)
        {
            this.first_name = first_name;
            this.second_name = second_name;
            this.salary = salary;

        }


    }

















}
