using System;
using System.Collections.Generic;
using System.Text;
using CSharpRefreshment.Math;
using System.IO;
using System.Threading;
using Amazon;

namespace CSharpRefreshment
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Promote();
            
        }
    }
}