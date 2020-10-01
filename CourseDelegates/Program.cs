using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDelegates
{

    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op0 = CalculationService.Sum;
            BinaryNumericOperation op1 = CalculationService.Max;
            double result2 = CalculationService.Square(a);


            double result0 = op0(a, b);
            double result1 = op1(a, b);

            Console.WriteLine(result0);
            Console.WriteLine(result1);
            Console.WriteLine(result2);

            Console.ReadLine();
        }
    }
}
