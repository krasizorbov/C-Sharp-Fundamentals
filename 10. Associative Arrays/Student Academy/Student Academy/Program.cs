

using System;
using System.Linq;
using System.Collections.Generic;
namespace StudentAcademy
{
    class Program
    {
        static void Main()
        {
            int numberPair = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> ListGrades = new Dictionary<string, List<double>>();
            string name = null;
            double grade;
            for (int i = 0; i < numberPair; i++)
            {
                name = Console.ReadLine();
                grade = double.Parse(Console.ReadLine());
                if (!ListGrades.ContainsKey(name))
                {
                    ListGrades.Add(name, new List<double>());
                    ListGrades[name].Add(grade);
                }
                else if (ListGrades.ContainsKey(name))
                {
                    ListGrades[name].Add(grade);
                }
            }

            var list = ListGrades.OrderByDescending(x => x.Value.Average()).ToList();
            foreach (var item in list)
            {

                if (item.Value.Average() >= 4.5)
                {
                    Console.WriteLine("{0} -> {1:f2}", item.Key, item.Value.OrderByDescending(x => x).Average());
                }
            }
        }
    }
}