using System;

namespace randnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(20, 8, 5));
            Console.WriteLine(Multiply(20, 444, 5));
            Console.ReadKey();
        }

        static double Multiply(double x, double y)
        {
            double z = x * y;
            return z;
        }

        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}
