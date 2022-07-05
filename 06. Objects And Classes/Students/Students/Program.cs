using System;
using System.Linq;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var students = new List<Student>();
            for (int i = 0; i < num; i++)
            {
                string[] data = Console.ReadLine().Split().ToArray();

                string firstName = data[0];
                string lastName = data[1];
                string grade = data[2];

               var student = new Student(firstName, lastName, grade);
                students.Add(student);
            }
            students = students.OrderByDescending(x => x.Grade).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, students));
        }
        
    }   
    class Student
    {
        public Student(string firstName, string lastName, string grade)
            {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
            }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade}";
        }
    }
}
