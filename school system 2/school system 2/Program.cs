using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_system_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter Student Information");
            Console.WriteLine();
            Console.Write("Enter Student Name: ");
            string studentName = Console.ReadLine();


            Console.Write("Enter Student Age: ");
            int studentAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Grade: ");
            int studentGrade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Average: ");
            double studentAverage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Student Gender (M/F): ");
            char studentGender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();

            
            Console.WriteLine(" Student Report ");
            Console.WriteLine();

            Console.WriteLine($"Welcome {studentName}!");
            Console.WriteLine();

            Console.WriteLine("Name: " + studentName);
            Console.WriteLine("Age: " + studentAge);
            Console.WriteLine("Grade: " + studentGrade);
            Console.WriteLine("Average: " + studentAverage);
            Console.WriteLine("Gender: " + studentGender);
            Console.WriteLine();


            Console.WriteLine("=== Name Information ===");
            Console.WriteLine();

            Console.WriteLine("Original Name: " + studentName);

            Console.WriteLine("Uppercase: " + studentName.ToUpper());

            Console.WriteLine("Lowercase: " + studentName.ToLower());

            Console.WriteLine("First Character: " + studentName[0]);
            Console.WriteLine();

            
            

            Console.WriteLine("=== Average Calculation ===");
            Console.WriteLine();

            int bonusMarks = 5;

            double newAverage = studentAverage + bonusMarks;

            Console.WriteLine("Original Average: " + studentAverage);
            Console.WriteLine("Bonus Marks: " + bonusMarks);
            Console.WriteLine("New Average: " + newAverage);
            Console.WriteLine();


            Console.WriteLine(" Student Status ");
            Console.WriteLine();

            bool isPassed = newAverage >= 50;

            bool isAdult = studentAge >= 18;

            Console.WriteLine("New Average: " + newAverage);
            Console.WriteLine("Passed: " + isPassed);
            Console.WriteLine("Adult: " + isAdult);
            Console.WriteLine();


            Console.WriteLine("STUDENT SUMMARY");
            Console.WriteLine();

            Console.WriteLine("Welcome " + studentName.ToUpper() + "!");
            Console.WriteLine();

            Console.WriteLine("Name: " + studentName);
            Console.WriteLine("Age: " + studentAge);
            Console.WriteLine("Grade: " + studentGrade);
            Console.WriteLine("Average: " + studentAverage);
            Console.WriteLine("New Average: " + newAverage);
            Console.WriteLine("Gender: " + studentGender);
            Console.WriteLine();

            Console.WriteLine("Result: " + (isPassed ? "Passed" : "Failed"));
            Console.WriteLine("Adult: " + isAdult);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
