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
            var person = new Person();
            person.SetBirthdate(new DateTime(1987, 5, 8));
            
            Console.WriteLine(person.GetBirthdate());
        }
    }
}