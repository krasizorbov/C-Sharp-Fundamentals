using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            arr[i] = num;
        }
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        int sum = arr.Sum();
        Console.WriteLine(sum);
    }
}
