using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Artur";
            bool isWorking = true;

            var random = 123;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine(random);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine(float.MinValue);

            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            //Overflow due to casting
            int i1 = 1000;
            byte b1 = (byte)i1;
            Console.WriteLine(b1);

            
            try
            {
                //Exception due to owerflow
                var number1 = "1234";
                byte b11 = Convert.ToByte(number1);
                Console.WriteLine(b11);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }

            try
            {
                string str = "true";
                bool g = Convert.ToBoolean(str);
                Console.WriteLine(g);
            }
            catch (Exception)
            {
                 
            }
        }
    }
}
