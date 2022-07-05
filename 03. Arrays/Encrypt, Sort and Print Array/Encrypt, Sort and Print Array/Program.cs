using System;

public class Program
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int sum = 0;
        int[] arr = new int[num];

        for (int i = 0; i < num; i++)
        {
            string word = Console.ReadLine();

            for (int j = 0; j < word.Length; j++)
            {
                if (word[j] == 'a' || word[j] == 'e'|| word[j] == 'i'
                  || word[j] == 'o'|| word[j] == 'u'|| word[j] == 'A'                
                  || word[j] == 'E'|| word[j] == 'I'|| word[j] == 'O' 
                  || word[j] == 'U')
                {
                    sum = sum + word[j] * word.Length;
                }
                else
                {
                    sum = sum + word[j] / word.Length;
                }

            }
            arr[i] = sum;
            sum = 0;
        }
        Array.Sort(arr);
        foreach (int item in arr)
        {
            Console.WriteLine(item);
        }
    }
}
