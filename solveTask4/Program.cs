namespace solveTask4
{
    internal class Program
    {
        // TASK 1
        public static void PrintWelcome(string userName)
        {

            Console.WriteLine($"Welcome to Spark to Code, {userName}");
        }
        static void Main(string[] args)
        {
            // TASK 1
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();
            PrintWelcome(userName);

            /////////
            

        }
    }
}
