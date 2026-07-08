namespace solveTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TASK 1: Write a C# program that takes user input for their name, age, height, and whether they are a student or not. Then, display the information back to the user in a formatted string.
            //Console.WriteLine("Enter your name:");
            //string userName = Console.ReadLine();
            //Console.WriteLine("Enter your age:");
            //int userAge = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your height:");
            //float userHeight = float.Parse(Console.ReadLine());
            //Console.WriteLine("Are you a student? (Trure/False):");
            //string isStudent = Console.ReadLine();
            //Console.WriteLine($"Name: {userName}, Age: {userAge}, " +
            //    $"Height: {userHeight}, Student: {isStudent}"); 

            // TASK 2: Write a C# program that takes user input for two numbers and performs basic arithmetic operations (addition, subtraction, multiplication, division) on them. Display the results to the user.
            Console.WriteLine("Enter the length: ");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width: ");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);


        }
    }
}
