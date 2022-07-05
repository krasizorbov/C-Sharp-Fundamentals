using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder(input);

            int counter = 0;

            int count = 0;

            int j = 0;

            int remaining = 0;

            int num = 0;

            for (int i = 0; i < sb.Length; i++)
            {
                if (char.IsNumber(sb[i]))
                {
                    num = (char)sb[i] - '0' + remaining;

                    for (j = i; j < i + num; j++)
                    {
                        if (j >= sb.Length)
                        {
                            counter = 1;
                            break;
                        }
                        else if (sb[j] == '>')
                        {
                            counter = 1;
                            break;
                        }
                        else
                        {
                            count++;
                            counter = 0;
                        }
                    }
                    if (counter == 0)
                    {
                        sb = sb.Remove(i, num);
                        i = 0;
                    }
                    else if (counter == 1)
                    {
                        if (remaining > sb.ToString().Length - i)
                        {
                            remaining = sb.ToString().Length - i;
                            sb = sb.Remove(i, remaining);
                        }
                        else
                        {
                            remaining = num - count;
                            sb = sb.Remove(i, j - i);
                        }
                        i = 0;
                    }
                }
                count = 0;
                num = 0;
            }
            Console.WriteLine(sb);
        }
    }
}

