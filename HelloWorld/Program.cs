using System;
using HelloWorld.Math;

namespace CSharpRefreshment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a serie of numbers separated by comma and press enter:");
            string enteredText = Console.ReadLine();
            var arrayOfNumbers = enteredText.Split(',');
            var maxNumber = Convert.ToInt32(arrayOfNumbers[0]);
            foreach (var item in arrayOfNumbers)
            {
                maxNumber = (maxNumber < Convert.ToInt32(item)) ? Convert.ToInt32(item) : maxNumber;
            }
            Console.WriteLine(maxNumber);
        }
    }
}
