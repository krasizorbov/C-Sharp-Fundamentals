using System;
using System.Linq;
using System.Collections.Generic;

namespace Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" -> ").ToArray();

            var companies = new Dictionary<string, List<string>>();
            
            var list = new List<string>();

            while (input[0] != "End")
            {
                string company = input[0];
                string userID = input[1];

                if (!companies.ContainsKey(company))
                {
                    list = new List<string>();
                    list.Add(userID);
                    companies.Add(company, list);
                    list = new List<string>();
                }
                else
                {
                    if (!companies[company].Contains(userID))
                    {
                        companies[company].Add(userID);
                    }
                }

                input = Console.ReadLine().Split(" -> ").ToArray();

            }//while loop ends here

            var finalList = companies.ToList();

            //finalList.OrderBy(x => x);

            foreach (var item in finalList.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var item1 in item.Value)
                {
                    Console.WriteLine("-- " + item1);
                }
                
            }
        }
    }
}
