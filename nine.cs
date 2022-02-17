using System;

namespace randnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?: ");
            String name = Console.ReadLine();
            Console.Write("What age are you?: ");
            int age = Convert.ToInt32(Console.ReadLine());
            singHappyBday(name, age);
            Console.ReadKey();
        }

        static void singHappyBday(String name, int age)
        {
            Console.WriteLine("Happy Birthday");
            Console.WriteLine("Happy Birthday");
            Console.WriteLine("Happy Birthday");
            Console.WriteLine("Happy Birthday dear " + name + "!");
            Console.Beep();
            Console.WriteLine("Happy Birthday");
            Console.WriteLine("Happy Birthday");
            Console.WriteLine("Happy Birthday dear " + name + "!");
            Console.Beep();
            Console.WriteLine("You are " + age + " now!");
        }
    }
}
