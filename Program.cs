using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  2) Format String example
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            // 1) Overflow example
            //byte number = 255;
            //number++; // overflows to 0
            //Console.WriteLine(number);

            //checked 
            //{
            //    number = 255;
            //    number++; // overflows to 0 and throws exception
            //}
        }
    }
}
