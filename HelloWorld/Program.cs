using System;
using HelloWorld.Math;

namespace CSharpRefreshment
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            const int PasswordLength = 10;
            char[] buffer = new char[PasswordLength];

            for (int i = 0; i < PasswordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }
            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
