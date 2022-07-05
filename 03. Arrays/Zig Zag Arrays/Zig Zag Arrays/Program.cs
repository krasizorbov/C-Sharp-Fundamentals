using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] arr1 = new string[n];
        string[] arr2 = new string[n];
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            if (i == 0 || i % 2 == 0)
            {
                arr1[i] = input.Split(' ')[0];
                arr2[i] = input.Split(' ')[1];
            }
            else
            {
                arr1[i] = input.Split(' ')[1];
                arr2[i] = input.Split(' ')[0];
            }
        }
        foreach (var item1 in arr1)
        {
            Console.Write(item1 + " ");
        }
        Console.WriteLine();
        foreach (var item2 in arr2)
        {
            Console.Write(item2 + " ");
        }
    }
}
