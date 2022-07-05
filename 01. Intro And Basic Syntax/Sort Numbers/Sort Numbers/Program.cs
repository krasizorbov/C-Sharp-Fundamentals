using System;

public class Program
{
    public static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());

        int[] arr = new int[] { n1, n2, n3 };

        Array.Sort<int>(arr);
        Array.Reverse(arr);

        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
    }
}