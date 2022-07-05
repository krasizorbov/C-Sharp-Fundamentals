using System;
using System.Linq;
using System.Collections.Generic;

namespace Order_by_age
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Person> personList = new List<Person>();

            while (input != "End")
            {
                string[] data = input.Split().ToArray();
                Person person = new Person();
                person.Name = data[0];
                person.Id = data[1];
                person.Age = int.Parse(data[2]);
                personList.Add(person);
                input = Console.ReadLine();
            }
            var result = personList.OrderBy(x => x.Age);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} with ID: {item.Id} is {item.Age} years old.");
            }
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
    }
}
