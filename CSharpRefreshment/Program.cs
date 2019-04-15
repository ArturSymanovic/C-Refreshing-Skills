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
            var path = @"C:\Users\Artur Symanovic\test.txt";
            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("FileName: " + Path.GetFileName(path));
            Console.WriteLine("Filename without extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
        }
    }
}