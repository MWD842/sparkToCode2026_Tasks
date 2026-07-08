namespace solveTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TASK 1: Write a C# program that takes user input for their name, age, height, and whether they are a student or not. Then, display the information back to the user in a formatted string.
            Console.WriteLine("Enter your name:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height:");
            float userHeight = float.Parse(Console.ReadLine());
            Console.WriteLine("Are you a student? (Trure/False):");
            string isStudent = Console.ReadLine();
            Console.WriteLine($"Name: {userName}, Age: {userAge}, " +
                $"Height: {userHeight}, Student: {isStudent}"); 
        }
    }
}
