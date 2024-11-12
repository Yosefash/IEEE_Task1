using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEEE_Task1
{
    public class Student
    {
        public string Name { get; set; }
        public double Score { get; set; }
        public Student() { }
        public Student(string name, float score)
        {
            Name = name;
            Score = score;
        }
    }
}
