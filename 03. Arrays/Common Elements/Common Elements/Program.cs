using System;

public class Program
{
    public static void Main()
    {
        string word1 = Console.ReadLine();
        string[] arr1 = word1.Split(' ');
        string word2 = Console.ReadLine();
        string[] arr2 = word2.Split(' ');

        for (int i = 0; i < arr2.Length; i++)
        {
            for (int j = 0; j < arr1.Length; j++)
            {
                if (arr2[i] == arr1[j])
                {
                    Console.Write(arr2[i] + " ");
                }
            }
        }
    }
}
