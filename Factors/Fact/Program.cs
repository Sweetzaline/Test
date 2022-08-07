using System;
namespace Fact
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int answer;
            Console.WriteLine("Enter a number to find the factorial: ");
            int value = Convert.ToInt32(Console.ReadLine());
            Factorial fact = new Factorial();
            answer = fact.methodForFactorial(value);
            Console.WriteLine("Factorial of your input is : {0}", answer);
            Console.ReadLine();
        }

        public int methodForFactorial(int n)
        {
            int answer = 1;

            while (n != 1)
            {
                answer = answer * n;
                n = n - 1;
            }
            return answer;
        }
    }
}