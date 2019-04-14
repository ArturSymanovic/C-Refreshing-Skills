using System;
using HelloWorld.Math;

namespace HelloWorld
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine(method);

            Console.WriteLine((int)method);
            var methodId = 2;
            Console.WriteLine((ShippingMethod)methodId);

            //Writeline implicitly calls ToString() anyways
            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine("aa " + shippingMethod);
        }
    }
}
