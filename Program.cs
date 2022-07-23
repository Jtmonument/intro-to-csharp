using System;

namespace HelloWorld
{
    internal class Program
    {

        private enum Method
        {
            GET = 1,
            POST,
            PUT,
            DELETE
        }

        static void Main(string[] args)
        {
            //  6) Enum example
            var getMethod = Method.GET;
            Console.WriteLine(getMethod);
            Console.WriteLine((int)Method.POST);

            var putMethod = 3;
            Console.WriteLine((Method)putMethod);

            var deleteMethod = "DELETE";
            var parsed = (Method)Enum.Parse(typeof(Method), deleteMethod);
            Console.WriteLine((int)parsed);

            //  5) String example
//            var person = new Person();
//            person.FirstName = "Jonathan";
//            person.LastName = "Taylor";
//            string name = string.Format("{0} {1}", person.FirstName, person.LastName);
//            Console.WriteLine(name);

//            var clangs = new string[] {"C", "C++", "C#"};
//            string strLangs = string.Join(", ", clangs);
//            Console.WriteLine(strLangs);

//            Console.WriteLine("Hello"[0]);

//            Console.WriteLine("C:\\Users\\jonta\\source\\repos\\HelloWorld\\Program.cs");
//            Console.WriteLine(@"C:\Users\jonta\source\repos\HelloWorld\Program.cs");

//            String lotsOfLines = @"1
//2
//3";
//            Console.WriteLine(lotsOfLines);


            //  4) Class example
            //var person = new Person();
            //person.FirstName = "Jonathan";
            //person.LastName = "Taylor";
            //person.Introduce();


            //  3) Type Conversion example
            //string s = "1";
            //int i = Convert.ToInt32(s);
            //int j = int.Parse(s);
            //Console.WriteLine("{0} {1} {2}", i, j, s);

            //i = 1000;
            //byte b = (byte)i;   //  data loss
            //Console.WriteLine(b);
            //try
            //{
            //    var num = "1000";
            //    b = Convert.ToByte(num);
            //    Console.WriteLine(b);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("num could not be converted to byte");
            //}
           

            //  2) Format String example
            //Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);


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
