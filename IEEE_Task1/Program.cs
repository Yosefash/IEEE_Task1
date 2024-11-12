namespace IEEE_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ScoreProcessor processor = new ScoreProcessor();

            foreach (Student student in processor.students)
            {
                processor.FilterStudent(student);

            }

            var stud = new List<Student>
            {
            new Student("Ahmed Mahmed Ali", 75),
            new Student("Mahmoud Ali Mahmed", 60),
            new Student("Mohand Mahmed Yasser", 88),
            new Student("Youssef Ahmed Khaled", 75),
            new Student("Ossama Mahmed Ali", 30),
            new Student("Ahmed  Ali Mahmed", 56),
            new Student("Ali Ahmed Mahmed", 44),
            new Student("waleed Mahmed Ali", 90)
        };

            foreach (Student student in stud)
            {
                processor.FilterStudent(student);

            }



            Console.WriteLine("All Student :");
            processor.students.PrintStudentList();
            Console.WriteLine("Passing Student :");
            processor.PassingStudent.PrintStudentList();
            Console.WriteLine("Failing Students :");
            processor.FailingStudent.PrintStudentList();

            Console.WriteLine();

            processor.students.TopScorer();
                
            processor.CalculateAverageScore(stud);
            //Console.WriteLine("PassingStudents");
            //processor.PassingStudents(student => student.Score >= 50);
            //Console.WriteLine("FailingStudents");
            //processor.PassingStudents(student => student.Score <= 50);
            Console.ReadKey();
        }
    }
}
