using System;
using System.Collections.Generic;
using System.Text;
 
namespace ConsoleApplication65
{
    class Program
    {
        static double Max(double a, double b)
        {
            return a > b ? a : b;
        }
        static double Min(double a, double b)
        {
            return a < b ? a : b;
        }
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double min, max;
 
            max = Max(a, Max(b, c));
            min = Min(a, Min(b, c));
 
            Console.WriteLine(max);
            Console.WriteLine(min);
 
            Console.ReadLine();
        }
    }
}
