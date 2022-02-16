using System;

namespace CsTut
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i > 0; i--)
            {
                Console.Beep();
                Console.WriteLine(i);
            }
            Console.WriteLine("Happy New Year!");
            Console.ReadKey();
        }
    }
}
