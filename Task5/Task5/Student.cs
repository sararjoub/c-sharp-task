using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Student : Person
    {
        public int Grade { get; set; }
        public string StudentId { get; set; }
        public Student(string name, int age, string studentId, int grade, string schoolName)

            : base(name, age, schoolName)
        {
            Grade = grade;
            StudentId = studentId;
        }
        public void DisplayStudentInfo()
        {
            Console.WriteLine($" Student Information:");
            Console.WriteLine($"School: {SchoolName}");
            DisplayInfo();  
            Console.WriteLine($"Grade: {Grade}");
            Console.WriteLine($"Student ID: {StudentId}");
            Console.WriteLine();
        }
    }
}
