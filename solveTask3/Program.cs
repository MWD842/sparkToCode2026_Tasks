namespace solveTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Write a program that takes two integers as input and prints the absolute difference between them.
            Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            int result = Math.Abs(num1 - num2);
            Console.WriteLine("The absolute difference is: " + result);

            ////////
        }
    }
}
