using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiters = new char[] {' ', '\t' };

            string[] input = Console.ReadLine().Split(delimiters , StringSplitOptions.RemoveEmptyEntries).ToArray();

            StringBuilder numbers = new StringBuilder();

            char first = 'a';
            char last = 'a';
            int counter1 = 0;
            int counter2 = 0;
            double x = 0.0;
            double y = 0.0;
            double sum = 0.0;

            foreach (var item in input)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    first = item[0];

                    if (i != 0 && i != item.Length - 1)
                    {
                        numbers.Append(item[i]);
                    }

                    last = item[item.Length - 1];
                }

                string num = numbers.ToString();
              
                if (char.IsUpper(first))
                {
                    for (char a = 'A'; a <= 'Z'; a++)
                    {
                        counter1++;
                        if (first == a)
                        {
                            break;
                        }
                    }
                    double number = double.Parse(num);

                    x = number / counter1;  
                }
                else if (char.IsLower(first))
                {
                    for (char a = 'a'; a <= 'z'; a++)
                    {
                        counter1++;
                        if (first == a)
                        {
                            break;
                        }
                    }
                    double number = double.Parse(num);

                    x = number * counter1;
                }

                if (char.IsUpper(last))
                {
                    for (char a = 'A'; a <= 'Z'; a++)
                    {
                        counter2++;
                        if (last == a)
                        {
                            break;
                        }
                    }
                    double number = double.Parse(num);
                   
                    y = x - counter2;  
                }
                else if (char.IsLower(last))
                {
                    for (char a = 'a'; a <= 'z'; a++)
                    {
                        counter2++;
                        if (last == a)
                        {
                            break;
                        }
                    }
                    double number = double.Parse(num);

                    y = x + counter2;
                }
                
                sum = sum + y;
                counter1 = 0;
                counter2 = 0;
                x = 0;
                y = 0;
                numbers.Clear();
            }//foreach loop ends here.
            Console.WriteLine("{0:F2}", sum);
        }
    }
}
