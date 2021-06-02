
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class DelegateForEach
    {
        public delegate bool criterion(StudentL student);
        public void DelegateForEachmain()
        {

            StudentL[] students = new StudentL[3];
            students[0] = new StudentL(10, "steve");
            students[1] = new StudentL(17, "bill");
            students[2] = new StudentL(18, "dell");


            criterion under18 = studentsunder18;
            printunder18(under18, students);


        }

        public bool studentsunder18(StudentL student)
        {
            return student.age < 18;
        }


        public void printunder18(criterion under18, StudentL[] students)
        {
            foreach (StudentL student in students)
            {
                if(under18(student))
                {
                    Console.WriteLine(student.name);
                }

            }

        }

    }

    public class StudentL
    {
        public int age;
        public string name;


        public StudentL(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

    }



}
