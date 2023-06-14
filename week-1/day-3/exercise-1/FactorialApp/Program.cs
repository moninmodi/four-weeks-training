using System;
namespace FactorialApp
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            long factorial = CalculateFactorial(number);

            Console.WriteLine($"The factorial of {number} is: {factorial}");
        }

        public static long CalculateFactorial(int number)
        {
            long factorial = 1;
            for(int i = 2; i<= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}