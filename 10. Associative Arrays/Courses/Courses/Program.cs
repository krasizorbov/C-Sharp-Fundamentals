using System;
using System.Linq;
using System.Collections.Generic;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            var names = new List<string>();

            string[] input = Console.ReadLine().Split(" : ").ToArray();

            while (input[0] != "end")
            {
                string courseName = input[0];
                string studentName = input[1];

                if (!courses.ContainsKey(courseName))
                {
                    names = new List<string>();
                    names.Add(studentName);
                    courses.Add(courseName, names);
                }
                else
                {
                    courses[courseName].Add(studentName);
                }

                input = Console.ReadLine().Split(" : ").ToArray();
            }

            foreach (var course in courses.OrderByDescending(x => x.Value.Count()))
            {
                Console.WriteLine("{0}: {1}",course.Key, course.Value.Count());

                foreach (var name in course.Value.OrderBy(n => n))
                {
                    Console.WriteLine("-- {0}", name);
                }
            }
        }
    }
}
