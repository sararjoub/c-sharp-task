using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        protected string SchoolName { get; set; }
        private string _internalCode;
        public Person(string name, int age, string schoolName)
        {
            Name = name;
            Age = age;
            SchoolName = schoolName;
            _internalCode = "person11";


        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
    }

}
