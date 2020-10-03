using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoursePredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncExample();

            Console.ReadLine();
        }

        public static void FuncExample()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.05));
            list.Add(new Product("HD Case", 80.90));

            //Func<Product, string> func = NameUpper;
            Func<Product, string> func = p => p.Name.ToUpper();

            List<string> result =  list.Select(func).ToList();
            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }

        //static string NameUpper(Product p)
        //{
        //    return p.Name.ToUpper();
        //}

        public static void ActionExample()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.05));
            list.Add(new Product("HD Case", 80.90));

            //Action<Product> act = p => { p.Price += p.Price * 0.1; };

            list.ForEach(p => { p.Price += p.Price * 0.1; });
            //list.ForEach(act);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }


        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }


        public static void PredicateEst()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.05));
            list.Add(new Product("HD Case", 80.90));


            //list.RemoveAll(p => p.Price >= 100.0);
            list.RemoveAll(ProductTestPredicate);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        public static bool ProductTestPredicate(Product p)
        {
            return p.Price >= 100.0;
        }

    }
}
