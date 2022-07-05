using System;
using System.Collections.Generic;


namespace Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string digit = string.Empty;
            int num = 0;
            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                digit = number[i].ToString();
                num = int.Parse(digit);
                for (int j = num - 1; j >= 1; j--)
                {
                    num = num * j;                    
                }
                sum = sum + num;
            }
            if (sum == int.Parse(number))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
