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
            //Console.WriteLine("Enter the age: ");
            //int age = int.Parse(Console.ReadLine());
            //if (age >= 0 && age <= 12)
            //{
            //    Console.WriteLine("Ticket Category: Children, Ticket Price: 2.000 OMR");
            //}
            //else if (age >= 13 && age <= 59)
            //{
            //    Console.WriteLine("Ticket Category: Adult, Ticket Price: 5.000 OMR");
            //}
            //else if (age >= 60)
            //{
            //    Console.WriteLine("Ticket Category: Senior, Ticket Price: 3.000 OMR");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid age.");

            //}

            // TASK 8: Write a C# program that takes user input for the total bill amount and checks if the user is eligible for a discount based on their membership status. If the user is a member and the total bill amount is greater than $20, apply a 15% discount and display the final amount. Otherwise, display the total bill amount without any discount.
            //Console.WriteLine("Enter the total bill amount: ");
            //double totalBill = double.Parse(Console.ReadLine());
            //Console.WriteLine(" Are you a member of the loyalty program? (yes/no): ");
            //string isMember = Console.ReadLine();
            //if (isMember == "yes" && totalBill > 20)
            //{
            //    double discount = totalBill * 0.15;
            //    double finalAmount = totalBill - discount;
            //    Console.WriteLine("Total bill amount: " + totalBill);
            //    Console.WriteLine("You are eligible for a 15% discount.");
            //    Console.WriteLine("Final amount after discount: " + finalAmount);
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible for a discount.");
            //    Console.WriteLine("Total bill amount: " + totalBill);
            //}

            // TASK 9: Write a C# program that takes user input for a number from 1 to 7 and displays the corresponding day of the week (e.g., 1 = Sunday, 2 = Monday, etc.). Use a switch statement to determine the day based on the input.
            //Console.WriteLine("Enter a number from 1 to 7 to check the day of the week: ");
            //int dayNumber = int.Parse(Console.ReadLine());
            //switch(dayNumber)
            //{
            //    case 1:
            //        Console.WriteLine("The day is Sunday.");
            //        break;
            //    case 2:
            //        Console.WriteLine("The day is Monday.");
            //        break;
            //    case 3:
            //        Console.WriteLine("The day is Tuesday.");
            //        break;
            //    case 4:
            //        Console.WriteLine("The day is Wednesday.");
            //        break;
            //    case 5:
            //        Console.WriteLine("The day is Thursday.");
            //        break;
            //    case 6:
            //        Console.WriteLine("The day is Friday.");
            //        break;
            //    case 7:
            //        Console.WriteLine("The day is Saturday.");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid day number.");
            //        break;
            //} 

            // TASK 10: Write a C# program that takes user input for two numbers and an operation (addition, subtraction, multiplication, division, modulus). Perform the specified operation on the numbers and display the result to the user.
            //Console.WriteLine("Enter the first number: ");
            //int firstNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second number: ");
            //int secondNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the operation (Addition, Subtraction, Multiplication, Division, Modulus): ");
            //string operation = Console.ReadLine();
            //if (operation == "Addition")
            //{
            //    int result = firstNumber + secondNumber;
            //    Console.WriteLine("Result: " + result);
            //}
            //else if (operation == "Subtraction ")
            //{
            //    int result = firstNumber - secondNumber;
            //    Console.WriteLine("Result: " + result);
            //}
            //else if (operation == "Multiplication")
            //{
            //    int result = firstNumber * secondNumber;
            //    Console.WriteLine("Result: " + result);
            //}
            //else if (operation == "Division")
            //{
            //    if (secondNumber != 0)
            //    {
            //        double result = (double)firstNumber / secondNumber;
            //        Console.WriteLine("Result: " + result);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error: Division by zero is not allowed.");
            //    }
            //}
            //else if (operation == "Modulus")
            //{
            //    if (secondNumber != 0)
            //    {
            //        int result = firstNumber % secondNumber;
            //        Console.WriteLine("Result: " + result);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error: Division by zero is not allowed.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid operation.");
            //}

            // TASK 11: Write a C# program that takes user input for their age, monthly income, and whether they have an existing loan. Based on the following criteria, determine if the user is eligible for a loan.
            //Console.WriteLine("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your monthly income: ");
            //double income = double.Parse(Console.ReadLine());
            //Console.WriteLine("Do you have an existing loan (yes/no): ");
            //string hasExistingLoan = Console.ReadLine().Trim().ToLower();

            //List<string> reasons = new List<string>();

            //if (age < 21 || age > 60)
            //    reasons.Add("age restrictions");

            //if (income < 400)
            //    reasons.Add("insufficient income");

            //if (hasExistingLoan == "yes")
            //    reasons.Add("existing loan");

            //if (reasons.Count == 0)
            //{
            //    Console.WriteLine("You are eligible for a loan.");
            //}
            //else
            //{
            //    Console.WriteLine("You are not eligible for a loan.");
            //    Console.WriteLine("Reasons for ineligibility:");
            //    foreach (string reason in reasons)
            //    {
            //        Console.WriteLine("- " + reason);
            //    }
            //} 

            // TASK 12: Write a C# program that takes user input for a region code (A, B, or C) and the weight of a package in kilograms. Based on the region code and weight, calculate the shipping cost using the following criteria.
            Console.WriteLine("Enter a region code (A: Local, B: Regional, C: International): ");
            string regionCode = Console.ReadLine().Trim().ToUpper();
            Console.WriteLine("Enter the package weight in kilograms: ");
            double weight = double.Parse(Console.ReadLine());
            double shippingCost = 0;
            bool isValidRegion = true;
            switch (regionCode)
            {
                case "A":
                    shippingCost = 1.000; 
                    break;
                case "B":
                    shippingCost = 3.000;
                    break;
                case "C":
                    shippingCost = 7.000;
                    break;
                default:
                    Console.WriteLine("Invalid region code.");
                    isValidRegion = false;
                    break;
            }
            if (isValidRegion)
            {
                double extraCost = 0;

                if (weight > 10)
                {
                    extraCost = 5.000;
                }
                else if (weight > 5 && weight < 10)
                {
                    extraCost = 2.000;
                }
                else
                {
                    extraCost = 0;
                }
                double totalCost = shippingCost + extraCost;
                Console.WriteLine("Base cost: " + shippingCost + " OMR");
                Console.WriteLine("Extra cost: " + extraCost + " OMR");
                Console.WriteLine("Total shipping cost: " + totalCost + " OMR");
            } 

        }
    }
}
