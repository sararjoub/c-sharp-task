using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Student Information :\n");

            Student student1 = new Student("Ahmad", 20, 85);
            Student student2 = new Student("Sara", 21, 92);
            Student student3 = new Student("Omar", 19, 78);

            student1.DisplayInfo();
            student2.DisplayInfo();
            student3.DisplayInfo();

            Console.ReadKey();
        }
    }
}
  
