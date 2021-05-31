using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning1
{
    class DelegateUse
    {
        public void DelegateUseMain()
        {
            List<Student> stuList = new List<Student>();
            stuList.Add(new Student { Id = 1, marks = 23 });
            stuList.Add(new Student { Id = 2, marks = 63 });
            stuList.Add(new Student { Id = 3, marks = 23 });
            stuList.Add(new Student { Id = 4, marks = 53 });

            IsStudentPromotable isEligible = new IsStudentPromotable(promote);

            Student.PromoteStudent(stuList, isEligible);

        }

        public bool promote(Student student)
        {
            return student.marks > 40;
        }


    }


    delegate bool IsStudentPromotable(Student stud);

    class Student
    {
        public int Id { get; set; }
        public int marks { get; set; }



        public static void PromoteStudent(List<Student> studentlist, IsStudentPromotable isEligible)
        {
            foreach (Student student in studentlist)
            {
                if (isEligible(student))
                {
                    Console.WriteLine(student.Id);
                }
            }
        }
    }

}
