using System;
using System.Collections.Generic;
using HelloWorld.Math;

namespace CSharpRefreshment
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Artur Symanovic ";
            Console.WriteLine("Trim: {0}", fullName.Trim());
            Console.WriteLine("ToUpper: {0}", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: {0}", firstName);
            Console.WriteLine("Last Name: {0}", lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("First Name {0}", names[0]);
            Console.WriteLine("Last Name {0}", names[1]);

            Console.WriteLine(fullName.Replace("Artur", "Arturaa"));

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToInt32(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));
            Console.WriteLine(price.ToString("C0"));

        }
    }
}