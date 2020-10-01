using System;

namespace CourseMethots
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));

            Console.ReadLine();
        }

        static void st()
        {
                                      //ano,mes,dia | horario
            DateTime dt = new DateTime(2020, 10, 01, 17, 53, 00);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
