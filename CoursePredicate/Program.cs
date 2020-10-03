using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursePredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.05));
            list.Add(new Product("HD Case", 80.90));

            Action<Product> act = p => { p.Price += p.Price * 0.1; };

            list.ForEach(p => { p.Price += p.Price * 0.1; });
            //list.ForEach(act);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            Console.ReadLine();
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
