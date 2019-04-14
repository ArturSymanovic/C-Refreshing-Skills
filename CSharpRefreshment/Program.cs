using System;
using System.Collections.Generic;
using HelloWorld.Math;

namespace CSharpRefreshment
{
    class Program
    {
        static void Main(string[] args)
        {
            var enteredNames = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter a name of a person who liked you post and press Enter key:");
                var enteredName = Console.ReadLine();
                if (enteredName.Length > 0)
                    enteredNames.Add(enteredName);
                else
                    break;
            }

            if (enteredNames.Count == 0)
                Console.WriteLine("No One Likes you post");
            else if (enteredNames.Count == 1)
                Console.WriteLine(enteredNames[0] + " likes you post");
            else if (enteredNames.Count == 2)
                Console.WriteLine(enteredNames[0] + " and " + enteredNames[1] + " likes you post");
            else
                Console.WriteLine(enteredNames[0] + ", " + enteredNames[1] + " and " 
                    + (enteredNames.Count - 2) + " others like you post");
        }
    }
}