using System;

namespace randnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(checkOut(8.99, 3.44, 1, 77, 22.7));
        }

        static double checkOut(params double[] nums)
        {
            double sum = 0;

            foreach (double num in nums)
            {
                sum += num;
            }

            return sum;
        }


    }
}

