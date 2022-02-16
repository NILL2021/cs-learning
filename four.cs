using System;

namespace CsTut
{
    class Program
    {
        static void Main(string[] args)
        {
            String lowercase = "steve";
            String a = lowercase.ToUpper();
            Console.Beep();
            Console.WriteLine(a);
            String lowercased = lowercase.Replace("e", "u");
            Console.WriteLine(lowercased);
            String username = lowercase.Insert(0,"@");
            Console.WriteLine(username + " or " + lowercased.Insert(0, "@"));
            int len = username.Length;
            Console.WriteLine("Your username (" + username + ") has "+len + " letters");
            Console.WriteLine("The first three letters are: " + username.Substring(0,3));

            Console.ReadKey();
        }
    }
}
