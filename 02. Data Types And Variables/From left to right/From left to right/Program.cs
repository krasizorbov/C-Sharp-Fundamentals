using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int[] arr1 = new int[n];
        string name = string.Empty;
        for (int i = 0; i < n; i++)
        {
            name = Console.ReadLine();
            string[] arr = name.Split(' ');
            long first = long.Parse(arr[0]);
            long second = long.Parse(arr[1]);
            sum = 0;
            if (first > second)
            {
                string result = Math.Abs(first).ToString();
                for (int j = 0; j < result.Length; j++)
                {
                    sum = sum + result[j] - '0';
                }
            }
            else if (second > first)
            {
                string result = Math.Abs(second).ToString();
                for (int j = 0; j < result.Length; j++)
                {
                    sum = sum + result[j] - '0';
                }
            }
            else if (first == second)
            {
                string result = Math.Abs(first).ToString();
                for (int j = 0; j < result.Length; j++)
                {
                    sum = sum + result[j] - '0';
                }
            }
            arr1[i] = sum;
        }
        foreach (int item in arr1)
        {
            Console.WriteLine(item.ToString());
        }
    }
}
