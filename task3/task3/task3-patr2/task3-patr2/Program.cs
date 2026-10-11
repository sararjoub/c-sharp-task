using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_patr2
{
    internal class PrograSchoolSystem
    {
        static void Main(string[] args)
        {
            string[] students = { "Sara", "Taymaa", "Raghad", "Doha", "Sondos" };
            int[] grades = { 75, 80, 85, 90, 95 };
            int choice = 0;
            do
            {
                Console.WriteLine("\n School System");
                Console.WriteLine("1- Display students");
                Console.WriteLine("2- Search for Students");
                Console.WriteLine("3- Check Students Result");
                Console.WriteLine("4- Exit");
                Console.WriteLine("Enter your choice :");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n Students Name");
                        for (int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine(students[i]);
                        }
                        Console.WriteLine("\n Students Grade :");
                        foreach (int grade in grades)
                        {
                            Console.WriteLine(grade);

                        }
                        break;
                    case 2:
                        
                        Console.Write("Enter student name to search: ");
                        string searchName = Console.ReadLine();

                        bool found = false;
                        int index = 0;
                        while (index < students.Length)
                        {
                            
                            if (students[index].ToLower() == searchName.ToLower())
                            {
                                Console.WriteLine("Student Found!");
                                found = true;
                                break;  
                            }
                            index++;
                        }

                        if (!found)
                        {
                            Console.WriteLine("Student Not Found.");
                        }
                        break;

                    case 3:
                        Console.Write("Enter student grade: ");
                        int gradeInput = int.Parse(Console.ReadLine());

                        if (gradeInput >= 90 && gradeInput <= 100)
                            Console.WriteLine("Excellent");
                        else if (gradeInput >= 80 && gradeInput <= 89)
                            Console.WriteLine("Very Good");
                        else if (gradeInput >= 70 && gradeInput <= 79)
                            Console.WriteLine("Good");
                        else if (gradeInput >= 60 && gradeInput <= 69)
                            Console.WriteLine("Pass");
                        else if (gradeInput < 60)
                            Console.WriteLine("Fail");
                        else
                            Console.WriteLine("Invalid grade!");
                        break;

                    case 4:
                        Console.WriteLine("Exiting... Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }

            } while (choice != 4);  

            Console.ReadKey();
        }
    }
}