using System;

namespace CsTut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name?");
            String name = Console.ReadLine();
            Console.WriteLine("Age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Beep();
            Console.WriteLine("Hello " + name + "! You are " + age + " years old.");
            Console.ReadKey();
        }
    }
}
