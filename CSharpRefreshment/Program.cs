using System;
using HelloWorld.Math;

namespace CSharpRefreshment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 7, 9, 2, 14, 6 };

            //Length
            Console.WriteLine("Length: " + numbers.Length);

            //IndexOf
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            //Clear
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of Clear():");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            //Copy
            int[] another = new int[3];
            Console.WriteLine("Effect of Copy():");
            Array.Copy(numbers, another, 3);
            foreach (var item in another)
            {
                Console.WriteLine(item);
            }

            //Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sorting");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }


            //Reverse()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
