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
            Customer customer = new Customer(1, "John");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            var order = new Order();
            customer.Orders.Add(order);
        }
    }
}