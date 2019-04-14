using System;
using HelloWorld.Math;

namespace CSharpRefreshment
{
    class Program
    {
        static void Main(string[] args)
        {
            //NumberValidation();
            MaximumofTwoNumbers();
            Console.WriteLine("\nEnd of program!");
        }

        private static void MaximumofTwoNumbers()
        {
            Console.WriteLine("Number Comparison Program");
            do
            {
                Console.WriteLine("\nPlease enter first integer number and press enter:");
                var isValid1 = Int32.TryParse(Console.ReadLine(), out int parsedValue1);
                Console.WriteLine("\nPlease enter second integer number and press enter:");
                var isValid2 = Int32.TryParse(Console.ReadLine(), out int parsedValue2);
                if (isValid1 && isValid2 && parsedValue1 > parsedValue2)
                {
                    Console.WriteLine(String.Format("The maximum of the two numbers: {0}", parsedValue1));
                }
                else if (isValid1 && isValid2 && parsedValue1 < parsedValue2)
                {
                    Console.WriteLine(String.Format("The maximum of the two numbers: {0}", parsedValue2));
                }
                else
                {
                    Console.WriteLine("One or both of the entered numbers are not valid integers");
                }
                Console.WriteLine("Try again?");
            } while (Console.ReadKey().KeyChar.ToString().ToLower() == "y");
        }

        private static void NumberValidation()
        {
            Console.WriteLine("Numbers between 1-10 validation program");
            do
            {
                Console.WriteLine("\nPlease enter an integer in a range from 1 to 10 and press enter:");
                Int32.TryParse(Console.ReadLine(), out int parsedValue);
                Console.WriteLine((parsedValue > 0 && parsedValue < 11) ? "Valid" : "Invalid");
                Console.WriteLine("Try again?");
            } while (Console.ReadKey().KeyChar.ToString().ToLower() == "y");
        }
    }
}
