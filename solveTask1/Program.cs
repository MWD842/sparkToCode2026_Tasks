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
            //Console.WriteLine("Enter the length: ");
            //double length = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the width: ");
            //double width = double.Parse(Console.ReadLine());

            //double area = length * width;
            //double perimeter = 2 * (length + width);

            //Console.WriteLine("Area: " + area);
            //Console.WriteLine("Perimeter: " + perimeter);

            // TASK 3: Write a C# program that takes user input for a number and checks if it is even or odd. Display an appropriate message based on the result.
            //Console.WriteLine("Enter the a number: "); 
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("The number is even.");
            //}
            //else
            //{
            //    Console.WriteLine("The number is odd.");
            //}

            // TASK 4: Write a C# program that takes user input for their age and checks if they are eligible to vote (age >= 18). Display an appropriate message based on the eligibility.
            //Console.WriteLine("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Do you have a vaild national ID? (yes/no): ");
            //string hasValidId = Console.ReadLine();
            //if (age >= 18 && hasValidId == "yes")
            //{
            //    Console.WriteLine("You are eligible to vote.");
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible to vote.");
            //}

            // TASK 5: Write a C# program that takes user input to check the grade of a student based on their score. Use a switch statement to display the corresponding grade (A, B, C, D, F) and a message indicating whether the student passed or failed.
            //Console.WriteLine("Enter your grade: ");
            //char grade = char.Parse(Console.ReadLine());
            //switch (grade) {
            //    case 'A':
            //    case 'a':
            //        Console.WriteLine("Excellent!");
            //        break;
            //    case 'B':
            //    case 'b':
            //        Console.WriteLine("Very Good!");
            //        break;
            //    case 'C':
            //    case 'c':
            //        Console.WriteLine("Good!");
            //        break;
            //    case 'D':
            //    case 'd':   
            //        Console.WriteLine("Pass!");
            //        break;
            //    case 'F':
            //    case 'f':
            //        Console.WriteLine("Fail!");
            //        break;
            //    default: Console.WriteLine("Invalid grade.");
            //        break;

            //}

            // TASK 6: Write a C# program that takes user input for a temperature in Celsius and converts it to Fahrenheit. Display the result to the user.
            //Console.WriteLine("Enter a temperature in Celsius: ");
            //int celsius = int.Parse(Console.ReadLine());
            //int fahrenheit = (celsius * 9 / 5) + 32;
            //Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
            //switch (celsius)
            //{
            //    case int n when (n < 10):
            //        Console.WriteLine("The temperature is COLD");
            //        break;
            //    case int n when (n >= 10 && n <= 30):
            //        Console.WriteLine("The temperature is Mild");
            //        break;
            //    case int n when (n > 30):
            //        Console.WriteLine("The temperature is HOT");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid temperature.");
            //        break; 
            //} 

            // TASK 7: Write a C# program that takes user input for age and determines the ticket category and price based on the following criteria.
            Console.WriteLine("Enter the age: ");
            int age = int.Parse(Console.ReadLine());
            if (age >= 0 && age <= 12)
            {
                Console.WriteLine("Ticket Category: Children, Ticket Price: 2.000 OMR");
            }
            else if (age >= 13 && age <= 59)
            {
                Console.WriteLine("Ticket Category: Adult, Ticket Price: 5.000 OMR");
            }
            else if (age >= 60)
            {
                Console.WriteLine("Ticket Category: Senior, Ticket Price: 3.000 OMR");
            }
            else
            {
                Console.WriteLine("Invalid age.");

            }
        }
    }
}
