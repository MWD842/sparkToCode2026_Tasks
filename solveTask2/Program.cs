namespace solveTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK 1: Write a program that counts down from a given number to zero and then prints "Liftoff!".
            //Console.WriteLine("Enter a starting number: ");
            //int start = int.Parse(Console.ReadLine());
            //for (int i = start; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Liftoff!");

            /////////

            //Task 2: Write a program that takes a positive whole number N as input and calculates the sum of all whole numbers from 1 to N.
            //Console.WriteLine("Enter a positive whole number N: ");
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    //Console.WriteLine(i);
            //    sum = sum + i;
            //}
            //Console.WriteLine($"The sum of all whole numbers from 1 to {n} is: {sum}");

            /////////

            //Task 3: Write a program that takes a positive whole number as input and prints the multiplication table for that number up to 10.
            //Console.WriteLine("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //int multi;
            //for (int i = 1; i <= 10; i++)
            //{
            //    multi = number * i;
            //    Console.WriteLine($"{number} x {i} = {multi}");
            //}

            /////////

            //Task 4: Write a program that prompts the user to enter a password. If the password is correct, print "Access Granted". If the password is incorrect, print "Access Denied" and prompt the user to enter the password again until the correct password is entered.
            bool isCorrectPassword = false;
            while (isCorrectPassword == false)
            {
                Console.WriteLine("Enter password: ");
                string password = Console.ReadLine();
                if (password == "Spark2026")
                {
                    isCorrectPassword = true;
                    Console.WriteLine("Access Granted");
                }
                else
                {
                    Console.WriteLine("Incorrect password. Please try again.");
                }
            }

            /////////

            //Task 5: Write a program that generates a number and prompts the user to guess the number. The program should give hints if the guess is too high or too low, and continue until the user guesses the correct number.
            Console.WriteLine("Guess the number: ");
            int secretNumber = 30; //int secretNumber = new Random().Next(1, 101); // Generates a random number between 1 and 100
            int guess;
            do
            {
                guess = int.Parse(Console.ReadLine());
                if (guess < secretNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
            } while (guess != secretNumber);
            Console.WriteLine("Congratulations! You guessed the number.");

            ////////

            //Task 6: Write a program that takes two numbers as input and divides the first number by the second number. The program should handle any exceptions that may occur, such as dividing by zero or invalid input.
            Console.WriteLine("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int DivideNumbers = firstNumber / secondNumber;
            try
            {
                Console.WriteLine("The result of dividing {0} by {1} is: {2}", firstNumber, secondNumber, DivideNumbers);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: {0}", "Cannot divide by zero.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid input format.");
            }

            /////////

            //Task 7: Write a program that displays a menu with three options: "1. Say Hello", "2. Show Current Time-of-day", and "3. Exit". The program should prompt the user to enter their choice and perform the corresponding action. If the user enters an invalid choice, the program should throw an exception and display an error message.
            //int choice = 0;
            //while (true)
            //{
            //    Console.WriteLine("Menu:\n1. Say Hello\n2. Show Current Time-of-day\n3. Exit");
            //    Console.Write("Enter your choice (1-3): ");
            //    try
            //    {
            //        choice = int.Parse(Console.ReadLine());
            //        switch (choice)
            //        {
            //            case 1:
            //                Console.WriteLine("\nHello!\n");
            //                break;
            //            case 2:
            //                Console.WriteLine($"\nCurrent Time-of-day: {DateTime.Now.ToString("hh:mm tt")}\n");
            //                break;
            //            case 3:
            //                Console.WriteLine("\nExit.");
            //                return;
            //            default:
            //                Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
            //                break;
            //        }

            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Error: Invalid input format. Please enter a valid number.");
            //    }
            //}

            /////////

            //Task 8: Write a program that takes a positive whole number as input and calculates the sum of all even numbers from 0 to that number.
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int evenSum = 0;
            for (int i = 0; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                }
            }
            Console.WriteLine("The sum of even numbers from 0 to {0} is: {1}", number, evenSum);



        }
    }
}
