using System;
using System.Collections.Generic;
using System.Text;
using HelloWorld.Math;
using System.IO;

namespace CSharpRefreshment
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2 };
            var smallests = GetSmallests(numbers, 3);

            foreach (var number in smallests)
            {
                Console.WriteLine(number);
            }
        }

        private static List<int> GetSmallests(List<int> list, int count)
        {
            if (list == null)
                throw new ArgumentNullException("list", "Initial List of numbers is null");
            if (count > list.Count || count<=0)
                throw new ArgumentOutOfRangeException("count", "Count should be between 0 and the number of integers in the initial list.");
            var buffer = new List<int>(list);
            var smallests = new List<int>();
            while (smallests.Count < count)
            {
                var min = GetSmallest(buffer);
                smallests.Add(min);
                list.Remove(min);
            }
            return smallests;
        }

        private static int GetSmallest(List<int> list)
        {
            //Assume the first number is smallest
            var min = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }
    }
}