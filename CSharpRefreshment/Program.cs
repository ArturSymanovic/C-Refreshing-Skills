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
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);
        }

    }
}