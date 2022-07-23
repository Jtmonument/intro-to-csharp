using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Overflows
            byte number = 255;
            number++; // overflows to 0
            Console.WriteLine(number);

            checked 
            {
                number = 255;
                number++; // overflows to 0 and throws exception
            }
        }
    }
}
