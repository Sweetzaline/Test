using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Program.factorial(y);
        }
        public static void factorial(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine($"{i} is the factor of {num}");
                }
            }

        }
    }
}