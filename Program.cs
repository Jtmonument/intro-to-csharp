using System;
using System.Collections.Generic;
using System.IO;

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
            // 12) Files example
            string file = "temp.txt";
            if (!File.Exists(file))
            {
                File.Create(file).Close();
            }
            var content = File.ReadAllText(@"HelloWorld.runtimeconfig.json");
            File.WriteAllText(file, content);
            Console.WriteLine(content);
            Directory.CreateDirectory("temp");
            File.Copy(file, @".\temp\temp.txt", true);
            var fileInfo = new FileInfo(file);
            Console.WriteLine(fileInfo.FullName);
            Console.Write("Check bin path for files...");
            Console.ReadKey();
            Console.WriteLine();
            File.Delete(file);
            Directory.Delete(@".\temp\", true);

            var files = Directory.GetFiles(".", "*.*", SearchOption.AllDirectories);
            foreach (var dir in files)
            {
                Console.WriteLine(dir);
            }

            var directories = new DirectoryInfo("../");
            foreach (var dir in directories.GetDirectories())
            {
                Console.WriteLine(dir);
            }
            foreach (var dir in directories.GetFiles())
            {
                Console.WriteLine(dir);
            }
            Console.WriteLine(Path.GetExtension("HelloWorld.exe"));


            // 11) TimeSpan example
            //var timeSpan = new TimeSpan(1, 2, 3);
            //var hour = TimeSpan.FromHours(1);

            //var startTime = DateTime.Now;
            //var endTime = DateTime.Now;
            //Console.WriteLine("Duration: {0} ms", (endTime - startTime).TotalMilliseconds);

            //Console.WriteLine("Minutes: {0}", timeSpan.Minutes);
            //Console.WriteLine("Total Minutes: {0}", timeSpan.TotalMinutes);

            //Console.WriteLine(timeSpan.Add(TimeSpan.FromDays(7)));
            //Console.WriteLine(timeSpan.Subtract(TimeSpan.FromDays(7)));

            //Console.WriteLine("Parse: {0}", TimeSpan.Parse("14:00:00"));
            //Console.WriteLine("Parse: {0}", DateTime.Parse("2020-01-01T14:00:00Z"));


            // 10) Dates example
            //var date = new DateTime(2022, 1, 1);
            //Console.WriteLine(date); // 1/1/2022 12:00:00 AM
            //var now = DateTime.Now;
            //var today = DateTime.Today;
            //Console.WriteLine(now);
            //Console.WriteLine(now.Day);
            //Console.WriteLine(now.Minute);
            //var tomorrow = now.AddDays(1);
            //var yesterday = now.AddDays(-1);
            //Console.WriteLine(tomorrow);
            //Console.WriteLine(yesterday);

            //Console.WriteLine(now.ToLongDateString()); // Day, Month, dd, yyyy
            //Console.WriteLine(now.ToShortDateString()); // MM/dd/yyyy
            //Console.WriteLine(now.ToLongTimeString()); // hh:mm:ss AM/PM
            //Console.WriteLine(now.ToShortTimeString()); // hh:mm AM/PM
            //Console.WriteLine(now.ToString("yyyy-MM-dd'T'HH:mm:ss'Z'"));


            //  9) List example
            //var list = new List<int>() { 1, 2, 3};
            //list.Add(4);
            //list.AddRange(new[] { 5, 2, 7});
            //Console.WriteLine(list.IndexOf(5));
            //Console.WriteLine(list.LastIndexOf(2));
            //list.Remove(7);
            //Console.WriteLine(list.Count);


            //  8) Arrays example
            //int[][] jaggedArray = new int[3][]; // Jagged Array
            //int[,] multidimensionalArray = new int[3, 3]; // Multidimensional Array
            //var shortHand = new[] { 5, 4, 3, 1, 2 }; // Shorthand way to create an array
            //Console.WriteLine(shortHand.Length); // Length of Array
            //Console.WriteLine(Array.IndexOf(shortHand, 3)); //  Index of Element in Array

            //Console.WriteLine("Array.Clear(shortHand, 0, 1)");
            //Array.Clear(shortHand, 0, 1);
            //foreach (var num in shortHand)
            //{
            //    Console.Write(num + " ");
            //}
            //shortHand[0] = 5;

            //Console.WriteLine("\nArray.Sort()");
            //Array.Sort(shortHand);
            //foreach (int num in shortHand)
            //{
            //    Console.Write(num + " ");
            //}

            //int[] copy = new int[3];
            //Array.Copy(shortHand, copy, 3);

            //Console.WriteLine("\nArray.Copy(shortHand, copy, 3)");
            //foreach (int num in copy)
            //{
            //    Console.Write(num + " ");
            //}

            //Console.WriteLine("\nArray.Clear(shortHand, 0, shortHand.Length)");
            //Array.Clear(shortHand, 0, shortHand.Length);
            //foreach (int num in shortHand)
            //{
            //    Console.Write(num + " ");
            //}


            //  7) Reference type example
            //Person person = new Person();
            //Person personRef = person;
            //personRef.FirstName = "John";
            //personRef.LastName = "Doe";
            //person.Introduce();


            //  6) Enum example
            //var getMethod = Method.GET;
            //Console.WriteLine(getMethod);
            //Console.WriteLine((int)Method.POST);

            //var putMethod = 3;
            //Console.WriteLine((Method)putMethod);

            //var deleteMethod = "DELETE";
            //var parsed = (Method)Enum.Parse(typeof(Method), deleteMethod);
            //Console.WriteLine((int)parsed);


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
