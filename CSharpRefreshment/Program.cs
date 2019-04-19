using System;
using System.Collections.Generic;
using System.Text;
using CSharpRefreshment.Math;
using System.IO;
using System.Threading;

namespace CSharpRefreshment
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Thread.Sleep(1500);
            stopWatch.Stop();
            Console.WriteLine(stopWatch.GetDuration());
            stopWatch.Start();
            Thread.Sleep(2000);
            stopWatch.Stop();
            Console.WriteLine(stopWatch.GetDuration());
        }
    }
}