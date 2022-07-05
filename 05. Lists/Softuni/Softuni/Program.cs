using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Problem
{
    class Program
    {
        static void Main()
        {
            var lessons = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                var command = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();

                var command1 = command[0];

                if (command1 == "course start")
                {
                    break;
                }

                if (command1 == "Add")
                {
                    if (!lessons.Contains(command[1]))
                    {
                        lessons.Add(command[1]);
                    }
                }
                else if (command1 == "Insert")
                {
                    if (!lessons.Contains(command[1]))
                    {
                        if (Convert.ToInt32(command[2]) < lessons.Count && Convert.ToInt32(command[2]) >= 0)
                        {
                            lessons.Insert(Convert.ToInt32(command[2]), command[1]);
                        }
                    }
                }
                else if (command1 == "Remove")
                {
                    lessons.Remove(command[1]);
                    lessons.Remove($"{command[1]}-Exercise");
                }
                else if (command1 == "Swap")
                {
                    string lessonTitle1 = command[1];
                    string lessonTitle2 = command[2];

                    int index1 = lessons.IndexOf(lessonTitle1);
                    int index2 = lessons.IndexOf(lessonTitle2);
                    if (index1 != -1 && index2 != -1)
                    {
                        lessons[index1] = lessonTitle2;
                        lessons[index2] = lessonTitle1;

                        if (index1 + 1 < lessons.Count && lessons[index1 + 1] == $"{lessonTitle1}-Exercise")
                        {
                            lessons.RemoveAt(index1 + 1);
                            index1 = lessons.IndexOf(lessonTitle1);
                            lessons.Insert(index1 + 1, $"{lessonTitle1}-Exercise");
                        }

                        if (index2 + 1 < lessons.Count && lessons[index2 + 1] == $"{lessonTitle2}-Exercise")
                        {
                            lessons.RemoveAt(index2 + 1);
                            index2 = lessons.IndexOf(lessonTitle2);
                            lessons.Insert(index2 + 1, $"{lessonTitle2}-Exercise");
                        }
                    }
                }
                else if (command1 == "Exercise")
                {
                    int index = lessons.IndexOf(command[1]);
                    if (lessons.Contains(command[1]) && !lessons.Contains($"{command[1]}-Exercise"))
                    {
                        lessons.Insert(index + 1, $"{command[1]}-Exercise");
                    }
                    else if (!lessons.Contains(command[1]))
                    {
                        lessons.Add(command[1]);
                        lessons.Add($"{command[1]}-Exercise");
                    }
                }
            }

            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }
    }
}