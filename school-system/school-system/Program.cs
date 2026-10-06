using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "sara";
            int age = 24;
            int grade = 90;
            double avarage = 94.5;
            char gender = 'f';
            bool isStudentActive = true;

            Console.WriteLine("-- Student Infromations--");
            Console.WriteLine();
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Avarage: {avarage}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Activ: {isStudentActive}");
            Console.WriteLine();
            string[] students = { "sara", "taymaa", "raghad", "saja", "doha" };
            Console.WriteLine("/// Students ////");
            Console.WriteLine("Student 1:" + students[0]);
            Console.WriteLine("Student 2:" + students[1]);
            Console.WriteLine("Student 3:" + students[2]);
            Console.WriteLine("Student 4:" + students[3]);
            Console.WriteLine("Student 5:" + students[4]);

            Console.WriteLine($"Number of Students: {students.Length}");
            Console.WriteLine();

            Console.WriteLine("--before change  --");
            Console.WriteLine(students[0]);
            Console.WriteLine(students[1]);
            Console.WriteLine(students[2]);
            Console.WriteLine(students[3]);
            Console.WriteLine(students[4]);
            Console.WriteLine();
            Console.WriteLine($"\nFirst student:" + students[0]);
            Console.WriteLine("Last student: " + students[4]);

            students[1] = "leen";
            Console.WriteLine();
            Console.WriteLine("\n After-- Change ");
            Console.WriteLine(students[0]);
            Console.WriteLine(students[1]);
            Console.WriteLine(students[2]);
            Console.WriteLine(students[3]);
            Console.WriteLine(students[4]);
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();


        }
    }
}