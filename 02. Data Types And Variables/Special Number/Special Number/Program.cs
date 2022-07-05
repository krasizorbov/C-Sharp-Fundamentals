using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int num = 0;
        string m = string.Empty;
        for (int j = 1; j <= n; j++)
        {
            m = j.ToString();
            for (int i = 0; i < m.Length; i++)
            {
                num = (int)m[i] - '0';
                sum += num;
                //Console.WriteLine(sum);
            }
            if (sum == 5 || sum == 7 || sum == 11)
            {
                Console.WriteLine("{0} -> True", j);
            }
            else
            {
                Console.WriteLine("{0} -> False", j);
            }
            sum = 0;
        }
    }
}