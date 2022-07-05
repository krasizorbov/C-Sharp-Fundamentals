using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Quests
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> myList = input.Split(", ").ToList();

            string command = Console.ReadLine();

            //string[] delimiters = new string[] { " - ", ":" };
            

            while (command != "Retire!")
            {
                string[] parts = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                if (parts[0] == "Start")
                {
                    if (!myList.Contains(parts[1]))
                    {
                        myList.Add(parts[1]);
                    }
                }
                if (parts[0] == "Complete")
                {
                    if (myList.Contains(parts[1]))
                    {
                        myList.Remove(parts[1]);
                    }
                }
                if (parts[0] == "Renew")
                {
                    if (myList.Contains(parts[1]))
                    {
                        myList.Remove(parts[1]);
                        myList.Add(parts[1]);
                    }
                }
                if (parts[0] == "Side Quest")
                {
                    string sideQuest = parts[1];
                    string[] sideQ = sideQuest.Split(":").ToArray();
                    if (myList.Contains(sideQ[0]))
                    {
                        if (!myList.Contains(sideQ[1]))
                        {
                            int index = myList.FindIndex(x => x == sideQ[0]);
                            myList.Insert(index + 1, sideQ[1]);
                        }
                    }
                }
                command = Console.ReadLine(); ;
            }
            Console.WriteLine(string.Join(", ", myList));       
        }
    }
}
