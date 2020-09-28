using Course;
using Course.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace CourseGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculationService();

            Console.ReadLine();
        }

        static void CalculationService() 
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);

            Console.Write("Max: ");
            Console.WriteLine(max);
        }

        static void PrintService()
        {
            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());

            Console.ReadLine();
        }
    }
}
