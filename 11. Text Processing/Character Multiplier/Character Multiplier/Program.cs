using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            int sum = Sum(input[0], input[1]);
            Console.WriteLine(sum);
        }

        public static string LongerString(string x, string y)
        {
            return x.Length > y.Length ? x : y;
        }

        public static int Sum(string x, string y)
        {
            string output = LongerString(x, y);
            int sum = 0;
            for (int i = 0; i < output.Length; i++)
            {
                if (x.Length < output.Length)
                {
                    if (i >= x.Length)
                    {
                        int first = (char)output[i];
                        int second = 1;
                        int multi = first * second;
                        sum = sum + multi;
                    }
                    else
                    {
                        int first = (char)output[i];
                        int second = (char)x[i];
                        int multi = first * second;
                        sum = sum + multi;
                    }
                }
                else if (y.Length < output.Length)
                {
                    if (i >= y.Length)
                    {
                        int first = (char)output[i];
                        int second = 1;
                        int multi = first * second;
                        sum = sum + multi;
                    }
                    else
                    {
                        int first = (char)output[i];
                        int second = (char)y[i];
                        int multi = first * second;
                        sum = sum + multi;
                    }
                }
                else if (x.Length == y.Length)
                {
                    int first = (char)x[i];
                    int second = (char)y[i];
                    int multi = first * second;
                    sum = sum + multi;
                }
            }
            return sum;
        }
    }
}
