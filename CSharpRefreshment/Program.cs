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
            const int MaxLength = 20;
            if (sentence.Length < MaxLength)
                Console.WriteLine(sentence);
            else
            {
                sentence.Substring(0, MaxLength);
                var words = sentence.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();
                foreach (var word in words)
                {
                    summaryWords.Add(word);
                    totalCharacters += word.Length + 1;
                    if (totalCharacters > MaxLength)
                        break;
                }
                var summary = String.Join(" ", summaryWords) + "...";
                Console.WriteLine(summary);
            }
        }
    }
}