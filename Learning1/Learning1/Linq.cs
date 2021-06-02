using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class Linq
    {   
        
        public void Linqmain()
        {

            StudentD[] students = new StudentD[3];
            students[0] = new StudentD(10, "steve");
            students[1] = new StudentD(19, "bill");
            students[2] = new StudentD(10, "oliver");

            StudentD[] studentsunder18 = students.Where(s => s.age < 18).ToArray();

            foreach (StudentD stud in studentsunder18)
            {
                Console.WriteLine(stud.name);
            }
 
            StudentD studentnamedbill = students.Where(s => s.name == "bill").FirstOrDefault();
            Console.WriteLine(studentnamedbill.age);

         



        }
    }



    class StudentD
    {
        public int age;
        public string name;

        public StudentD(int age, string name)
        {
            this.age = age;
            this.name = name;
        } 


    }





}
