namespace solveTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK 1: Write a program that counts down from a given number to zero and then prints "Liftoff!".
            Console.WriteLine("Enter a starting number: ");
            int start = int.Parse(Console.ReadLine());
            for (int i = start; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Liftoff!");
        }
    }
}
