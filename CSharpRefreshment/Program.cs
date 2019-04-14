using System;
using System.Collections.Generic;
using HelloWorld.Math;

namespace CSharpRefreshment
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be very very very very very very long text";
            Console.WriteLine(StringUtility.SummarizeText(sentence, 25));

        }

        
    }
}