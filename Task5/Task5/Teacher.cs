using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Teacher : Person
    {

        public string Subject { get; set; }

        public Teacher(string name, int age, string schoolName, string subject)
            : base(name, age, schoolName)
        {
            Subject = subject;
        }

        public void DisplayTeacherInfo()
        {
            Console.WriteLine($"Teacher Information:");
            Console.WriteLine($"School: {SchoolName}");
            DisplayInfo();
            Console.WriteLine($"Subject: {Subject}");
            Console.WriteLine();
        }
    }
}


