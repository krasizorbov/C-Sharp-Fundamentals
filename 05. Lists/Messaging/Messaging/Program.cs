using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string text = Console.ReadLine();
            List<char> final = new List<char>();
            List<int> sumNumbers = new List<int>();
            StringBuilder builder = new StringBuilder();
            builder.Append(text);
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                string number = numbers[i];
                for (int j = 0; j < number.Length; j++)
                {
                    sum = sum + number[j] - '0';
                }
                sumNumbers.Add(sum);
                sum = 0;
            }
            for (int i = 0; i < sumNumbers.Count; i++)
            {
                if (sumNumbers[i] > builder.Length - 1)
                {
                    int starIndex = sumNumbers[i] - builder.Length;
                    final.Add(builder[starIndex]);
                    builder.Remove(starIndex, 1);
                }
                else if(sumNumbers[i] < text.Length - 1)
                {
                    final.Add(builder[sumNumbers[i]]);
                    builder.Remove(i, 1);
                }
            }
            Console.WriteLine(string.Join("",final));
        }
    }
}
    //StringBuilder sb = new StringBuilder();

    //sb.Append("text"); //to add text in front

    //sb.Insert(50,"text"); // to insert text

    //sb.Remove(50,4); // to remove text

    //sb.ToString(); // to produce the string