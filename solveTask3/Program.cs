namespace solveTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Write a program that takes two integers as input and prints the absolute difference between them.
            //Console.WriteLine("Enter the first number: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second number: ");
            //int num2 = int.Parse(Console.ReadLine());
            //int result = Math.Abs(num1 - num2);
            //Console.WriteLine("The absolute difference is: " + result);

            ////////

            // Task 2: Write a program that takes a positive whole number as input and prints the factorial of that number.
            //Console.WriteLine("Enter a number:");
            //double number = double.Parse(Console.ReadLine());
            //double Power = Math.Pow(number, 2);
            //Console.WriteLine($"The square of the {number} is: {Power}");
            //double squareRoot = Math.Sqrt(number);
            //Console.WriteLine($"The square root of the {number} is: {squareRoot}");

            ////////

            // Task 3: Write a program that takes a string as input and prints the string in uppercase, lowercase, and the length of the string.
            //Console.WriteLine("Enter your name: ");
            //string upper = Console.ReadLine().ToUpper();
            //string lower = upper.ToLower();
            //string length = upper.Length.ToString();
            //Console.WriteLine("Your name in uppercase is: " + upper);
            //Console.WriteLine("Your name in lowercase is: " + lower);
            //Console.WriteLine("The length of your name is: " + length);

            ////////

            // Task 4: Write a program that takes a positive whole number as input and prints the multiplication table for that number up to 10.
            //Console.WriteLine("Enter the number of days of a free trial: ");
            //int days = int.Parse(Console.ReadLine());
            //DateTime today = DateTime.Today.AddDays(days);
            //Console.WriteLine("The free trial will end on: " + today.ToString("D"));

            ////////

            // Task 5: Write a program that takes a positive whole number as input and prints the Fibonacci sequence up to that number.
            //Console.WriteLine("Enter a exam score: ");
            //double score = double.Parse(Console.ReadLine());
            //double grade = Math.Round(score);
            //if (grade >= 60)
            //{
            //    Console.WriteLine("The student has passed the exam.");
            //}
            //else
            //{
            //    Console.WriteLine("The student has failed the exam.");
            //}

            ////////

            // Task 6: Write a program that checks if a given password is strong or weak. A strong password should be at least 8 characters long and should not contain the word "password".
            Console.WriteLine("Enter the password: ");
            string password = Console.ReadLine().ToLower();
            double length = password.Length;
            string check = password.Contains("password") ? "Yes" : "No";

            if (length <= 8 && check == "No")
            {
                Console.WriteLine("Strong Password");
            }
            else
            {
                Console.WriteLine("Weak Password");
                if (length < 8)
                {
                    Console.WriteLine("The password is too short. It must be at least 8 characters long.");
                }
                if (check == "Yes")
                {
                    Console.WriteLine("The password contains the word 'password'. Please choose a different password.");
                }
            }

            ////////
        }
    }
}
