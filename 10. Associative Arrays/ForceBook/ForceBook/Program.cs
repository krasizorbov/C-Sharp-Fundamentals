using System;
using System.Linq;
using System.Collections.Generic;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var sides = new Dictionary<string, List< string >> ();

            var list = new List<string>();

            string input = string.Empty;

            input = Console.ReadLine();

            while (input != "Lumpawaroo")
            {
                string delimiter1 = " | ";
                string delimiter2 = " -> ";
                
                if (input.Contains(delimiter1))
                {
                    string[] data = input.Split(" | ").ToArray();
                    string forceSide = data[0];
                    string forceUser = data[1];


                    if (!sides.ContainsKey(forceSide))
                    {
                        if (!sides.Values.Any(x => x.Contains(forceUser)))
                        {
                            list.Add(forceUser);
                            sides.Add(forceSide, list);
                            list = new List<string>();
                        }

                    }
                    else
                    {
                        if (!sides.Values.Any(x => x.Contains(forceUser)))
                        {
                            list = new List<string>();
                            list.Add(forceUser);
                        }
                    }
                }
                else if (input.Contains(delimiter2))
                {
                    string[] data = input.Split(" -> ").ToArray();
                    
                    string forceSide = data[1];
                    string forceUser = data[0];

                    if (!sides.ContainsKey(forceSide))
                    {
                        if (!sides.Values.Any(x => x.Contains(forceUser)))
                        {
                            list.Add(forceUser);
                            sides.Add(forceSide, list);
                            list = new List<string>();
                            Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                        }

                    }
                    else
                    {
                        if (sides.Values.Any(x => x.Contains(forceUser)))
                        {
                            foreach (var item in sides)
                            {
                                if (item.Value.Contains(forceUser))
                                {
                                    item.Value.Remove(forceUser);
                                }
                            }

                            if (sides.ContainsKey(forceSide) == false)
                            {
                                sides.Add(forceSide, new List<string>());
                            }
                            sides[forceSide].Add(forceUser);
                            Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                        }
                    }
                }

                input = Console.ReadLine();

            }//while loop ends here

            var final = sides.ToList();

            foreach (var item in final.OrderBy(x => x.Key).ThenBy(x => x.Value.Count()))
            {
                if (item.Value.Count() > 0)
                {
                    Console.WriteLine("Side: {0}, Members: {1}", item.Key, item.Value.Count());
                }
                
                foreach (var item1 in item.Value.OrderBy(n => n))
                {
                    Console.WriteLine("! {0}", item1);
                }
            }
        }
    }
}
