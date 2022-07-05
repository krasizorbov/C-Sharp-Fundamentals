using System;
using System.Linq;
using System.Collections.Generic;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            //contest.Key and (username and points).Value
            var contests = new Dictionary<string, Dictionary<string, int>>();
            //username.Key and total sum of points.Value
            var users = new Dictionary<string, int>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" -> ").ToArray();

                if (input[0] == "no more time")
                {
                    break;
                }

                string username = input[0];
                string contest = input[1];
                int points = int.Parse(input[2]);

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, new Dictionary<string, int>());
                    contests[contest][username] = points;
                }
                else
                {
                    if (!contests[contest].ContainsKey(username))
                    {
                        contests[contest][username] = points;
                    }
                    else
                    {
                        if (contests[contest][username] < points)
                        {
                            contests[contest][username] = points;
                        }
                    }
                }
            }//while loop ends here.
            
            foreach (var contest in contests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count()} participants");
                int counter = 0;
                foreach (var name in contest.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    counter++;
                    Console.WriteLine($"{counter}. {name.Key} <::> {name.Value}");
                }
                counter = 0;
            }

            Console.WriteLine("Individual standings:");

            foreach (var contest in contests)
            {
                foreach (var name in contest.Value)
                {
                    if (!users.ContainsKey(name.Key))
                    {
                        users.Add(name.Key, name.Value);
                    }
                    else
                    {
                        users[name.Key] = users[name.Key] + name.Value;
                    }
                }
            }
            int counter1 = 0;
            foreach (var name in users.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                counter1++;
                Console.WriteLine($"{counter1}. {name.Key} -> {name.Value}");
            }
        }
    }
}
