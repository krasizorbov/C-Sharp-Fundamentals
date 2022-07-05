using System;
using System.Linq;
using System.Collections.Generic;

namespace Softuni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Dictionary<string, int>();

            var languages = new Dictionary<string, int>();

            string data = Console.ReadLine();

            while (data != "exam finished")
            {
                string[] input = data.Split("-").ToArray();
                string name = input[0];
                string language = input[1];

                if (language == "banned")
                {
                    students.Remove(name);
                    data = Console.ReadLine();
                    continue;
                }
                else
                {
                    int points = int.Parse(input[2]);

                    if (!students.ContainsKey(name))
                    {
                        students.Add(name, points);
                    }
                    else
                    {
                        if (points > students[name])
                        {
                            students[name] = points;
                        }
                    }
                }
                
                if (!languages.ContainsKey(language))
                {
                    languages[language] = 0;
                }

                languages[language]++;

                data = Console.ReadLine();

            }//end of while loop

            //order by descending by points then by user name

            Console.WriteLine("Results:");

            foreach (var item in students.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var item in languages.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
