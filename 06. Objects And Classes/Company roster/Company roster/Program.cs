using System;
using System.Linq;
using System.Collections.Generic;

namespace Company_roster
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var employees = new List<Employee>();

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string department = input[2];

                var newEmployee = new Employee(name, salary, department);
                employees.Add(newEmployee);
            }

            var result = employees.GroupBy(e => e.Department).Select(e => new
            {
                Department = e.Key,
                AverageSalary = e.Average(emp => emp.Salary),
                Employees = e.OrderByDescending(emp => emp.Salary)
            })
                .OrderByDescending(dep => dep.AverageSalary)
                .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {result.Department}");

            foreach (var employee in result.Employees)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }
        }
    }
    class Employee
    {
        public Employee(string name, decimal salary, string depatment)
        {
            Name = name;
            Salary = salary;
            Department = depatment;
        }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
    }
}
