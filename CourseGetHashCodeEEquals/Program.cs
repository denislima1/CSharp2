using CourseGetHashCodeEEquals.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseGetHashCodeEEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com"};
            Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            Console.ReadLine();
        }

        static void equals()
        {
            string a = "Maria";
            string b = "Alex";

            Console.WriteLine("Equals: " + a.Equals(b));
        }

        static void getHashCode()
        {
            string a = "Maria";
            string b = "Alex";

            Console.WriteLine("GetHashCode A: " + a.GetHashCode());
            Console.WriteLine("GetHashCode B: " + b.GetHashCode());
        }
    }
}
