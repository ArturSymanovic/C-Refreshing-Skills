using System;
using HelloWorld.Math;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Artur";
            string lastName = "Symanovic";
            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);
            var names = new string[3] { "John", "Jack", "Marry" };
            var formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames);
            var text = "Hi John\nLook into the following paths\nc:\\folder2\nc:\\folder3\nc:\\folder4";
            var text1 = @"Hi John
Look into the following paths
c:\folder2
c:\folder3
c:\folder4";
            Console.WriteLine(text);
            Console.WriteLine(text1);
        }
    }
}
