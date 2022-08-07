using System;
namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,  remainder, reverse = 0;

            Console.WriteLine("Enter an Number to be reversed \n");

            num = int.Parse(Console.ReadLine());

           
            while (num > 0)
            {
                remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num /= 10;
            }

            Console.WriteLine("The reverse of the number is = {0}", reverse);
            Console.Read();
        }
    }
}