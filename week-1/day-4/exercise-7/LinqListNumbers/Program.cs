namespace LinqListNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of integers
            List<int> numbers = new List<int> { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

            // Use LINQ to perform the following operations:
            // 1. Find all even numbers
            // 2. Find all numbers greater than a specific value (e.g., 20)
            // 3. Calculate the sum of all numbers
            // 4. Calculate the average of all numbers
            // 5. Find the minimum and maximum values in the list
            var even = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("All even numbers");
            foreach (var number in even)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Enter the number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("All numbers greater than specified numbers are: ");
            var greater = numbers.Where(n => n > x);
            foreach(var number in greater)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Sum of all the numbers in list: ");
            var sum = numbers.Sum();
            Console.WriteLine(sum);
            Console.WriteLine("Average of all numbers: ");
            var average = numbers.Average();
            Console.WriteLine(average);
            Console.WriteLine("Minimum and Maximum numbers in the given list: ");
            var min = numbers.Min();
            var max = numbers.Max();
            Console.WriteLine(min);
            Console.WriteLine(max);
        }
    }
}