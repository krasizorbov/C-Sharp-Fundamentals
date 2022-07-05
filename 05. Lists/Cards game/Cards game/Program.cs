using System;
using System.Linq;
using System.Collections.Generic;

namespace Cards_game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            int a = 0;

            while (true)
            {
                if (firstPlayer[0] > secondPlayer[0])
                {

                    firstPlayer.Add(firstPlayer[0]);
                    firstPlayer.Add(secondPlayer[0]);
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }
                else if (firstPlayer[0] < secondPlayer[0])
                {

                    secondPlayer.Add(secondPlayer[0]);
                    secondPlayer.Add(firstPlayer[0]);
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }
                else if (firstPlayer[0] == secondPlayer[0])
                {
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }

                if (!firstPlayer.Any())
                {
                    a = 2;
                    break;
                }
                else if (!secondPlayer.Any())
                {
                    a = 1;
                    break;
                }
            }

            if (a == 1)
            {
                int sum = firstPlayer.Sum();
                Console.WriteLine("First player wins! Sum: {0}", sum);
            }
            else if (a == 2)
            {
                int sum = secondPlayer.Sum();
                Console.WriteLine("Second player wins! Sum: {0}", sum);
            }
        }
    }
}
