using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEEE_Task1
{
    internal class ScoreProcessor
    {
        public delegate bool StudentScoreCriteria(Student student);

        public List<Student> students = new List<Student>();
        public List<Student> PassingStudent = new List<Student>();
        public List<Student> FailingStudent = new List<Student>();


        public ScoreProcessor()
        {
           
        }

        public void FilterStudent(Student student)
        {
            students.Add(student);
            if (student.Score>=50)
            {
                PassingStudent.Add(student);
            }
            else 
            {
                FailingStudent.Add(student);
            }
        }
        public void CalculateAverageScore(List<Student> students)
        {
            double TotalScore = 0;
            double AverageScore = 0;

            foreach (Student student in students)
            {
                TotalScore += student.Score;

            }
            AverageScore= TotalScore/students.Count();
            Console.WriteLine($"The Average Score of All Students is : {AverageScore}");
        }
        public void StudentScore(StudentScoreCriteria filterdelegate)
        {
            foreach (Student student in students)
            {
                if (filterdelegate(student))
                {
                    Console.WriteLine(student.Name);
                }

            }
        }
      
      
        

    }
}
