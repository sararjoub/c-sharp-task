using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("School System :");
            Student student1 = new Student("Sara",24,"E02",90, "Just school");
            Student student2 = new Student("Doha", 23, "S02", 80, "Just school");
            Teacher teacher = new Teacher("Ms. Rahaf", 40, "Just school", "computer scince");
            student1.DisplayInfo();
            Console.WriteLine();
            student2.DisplayInfo();
            Console.WriteLine();
            student1.DisplayStudentInfo();
            student2.DisplayStudentInfo();

            teacher.DisplayTeacherInfo();

            SchoolReport report = new SchoolReport("Final Report");
            report.DisplayReportTitle();


        }
    }
}

