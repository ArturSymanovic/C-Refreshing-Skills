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
            //Value Types
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(String.Format("a: {0}, b: {1}", a, b));

            //Reference Types
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(String.Format("array1[0]: {0}, array2[0]: {1}"
                                , array1[0]
                                , array2[0]));

            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            Person person = new Person { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
