using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double[] arr = new double[n];
        string[] arr1 = new string[n];

        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double result = Math.PI * radius * radius * height;

            arr[i] = result;
            arr1[i] = name;
        }
        double max = arr.Max();
        int p = Array.IndexOf(arr, max);
        string name1 = arr1[p];
        Console.WriteLine(name1);
    }
}
