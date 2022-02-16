using System;

namespace CsTut
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "";
            
            while (name == "")
            {
                Console.Write("Name: ");
                name = Console.ReadLine();
            }
            Console.WriteLine(name);

            Console.Beep();
            Console.ReadKey();
        }
    }
}
