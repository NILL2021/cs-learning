using System;

namespace CsTut
{
    class Program
    {
        static void Main(string[] args)
        {
            int jimsAge;
            jimsAge = 123;
            double height = 6000000.1;
            bool egg = true;
            char symbol = '£';
            String name = "Timmy";
            double a = 22.5;
            int b = Convert.ToInt32(a);

            int c = 200;
            double d = Convert.ToDouble(c);

            Console.WriteLine(b);
            Console.WriteLine(a.GetType());
            Console.WriteLine(d);
            Console.WriteLine(Convert.ToString(c));


            Console.WriteLine("Hello " + name);
            Console.WriteLine("Height: " + height);
            
            Console.Write("Hello, World!");
            Console.WriteLine("hey");
            Console.Beep();
            Console.WriteLine("Are you an egg? " + egg + " Mr." + symbol);
            Console.WriteLine("\tJ\ni\bm");
            Console.ReadKey();
        }
    }
}
