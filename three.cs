using System;

namespace CsTut
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double a = random.NextDouble();
            Console.WriteLine(a);


            Console.ReadKey();
        }
    }
}
