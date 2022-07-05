
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ExamPrepJuly
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sum = 0;
            while (myList.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int valueAtIndex = 0;
                if (index < 0)
                {
                    //here we get the value of the index that we want to remove
                    valueAtIndex = myList[0];
                    myList[0] = myList[myList.Count - 1];
                    sum += valueAtIndex;
                }
                else if (index > myList.Count - 1)
                {
                    //here we get the value of the index that we want to remove
                    valueAtIndex = myList[myList.Count - 1];
                    myList[myList.Count - 1] = myList[0];
                    sum += valueAtIndex;
                }
                else
                {
                    //here we get the value of the index that we want to remove
                    valueAtIndex = myList.ElementAt(index);
                    myList.RemoveAt(index);
                    sum += valueAtIndex;
                }

                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i] <= valueAtIndex)
                    {
                        myList[i] += valueAtIndex;
                    }
                    else if (myList[i] > valueAtIndex)
                    {
                        myList[i] -= valueAtIndex;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}    