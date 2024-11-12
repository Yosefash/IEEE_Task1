using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEEE_Task1
{
    internal static class StudentExtension
    {
        public static void PrintStudentList(this List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Score: {student.Score}");
            }
        }
        public static void TopScorer(this List<Student> students)
        {
            Student TopStudent =new Student("000",0);

            foreach (Student student in students)
            {
                if (student.Score >= TopStudent.Score)
                {
                    TopStudent.Score = student.Score;
                    TopStudent.Name = student.Name;
                    
                }

            }
            Console.WriteLine($"Name: {TopStudent.Name}, Score: {TopStudent.Score}");

        }
    }

}
