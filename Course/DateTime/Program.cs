﻿//using System;
//using System.Collections.Generic;
//using System.Globalization;

//namespace Course
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            DateTime d1 = DateTime.Now;
//            DateTime d2 = DateTime.Today;
//            DateTime d3 = DateTime.UtcNow;
            
//            DateTime d4 = new DateTime(2020, 09, 06);
//            DateTime d5 = new DateTime(2020, 09, 06, 12, 16, 20);
//            DateTime d6 = new DateTime(2020, 09, 06, 12, 16, 20, 500);

//            DateTime d7 = DateTime.Parse("2000-08-15");
//            DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");

//            DateTime d9 = DateTime.Parse("15/08/2000");
//            DateTime d10 = DateTime.Parse("15/08/2000 13:05:58");

//            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
//            DateTime d12 = DateTime.ParseExact("15-08-2000 13:05:58", "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);

//            Console.WriteLine(d1);
//            Console.WriteLine(d2);
//            Console.WriteLine(d3);
//            Console.WriteLine(d4);
//            Console.WriteLine(d5);
//            Console.WriteLine(d6);
//            Console.WriteLine(d7);
//            Console.WriteLine(d8);
//            Console.WriteLine(d9);
//            Console.WriteLine(d10);
//            Console.WriteLine(d11);
//            Console.WriteLine(d12);

//            Console.ReadLine();
//        }
//    }
//}
