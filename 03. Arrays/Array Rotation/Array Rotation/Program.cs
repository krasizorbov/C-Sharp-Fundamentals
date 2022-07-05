using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise50
{
    public static void Main()
    {
        string word = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());

        string[] nums = word.Split(' ');
        
        for (int j = 0; j < n; j++)
        {
            var temp = nums[0];
            for (var i = 0; i < nums.Length - 1; i++)
            {
                nums[i] = nums[i + 1];
            }
            nums[nums.Length - 1] = temp;
        }

        Console.WriteLine("{0}", string.Join(" ", nums));
    }
}