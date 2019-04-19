using System;
using System.Collections.Generic;
using System.Text;
using CSharpRefreshment.Math;
using System.IO;
using System.Threading;
using Amazon;
using System.Collections;

namespace CSharpRefreshment
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            stack.Clear();
            stack.Push(3);
            stack.Push(2);
            
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }

    }
}