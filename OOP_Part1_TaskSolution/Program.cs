using System;
using System.Xml.Serialization;

namespace OOP_Part1_TaskSolution
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }

        public void Deposit(double amount)
        {
            Balance += amount;
            SendEmail();
        }
        
        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            SendEmail();
        }

        public double CheckBalance()
        {
            PrintInformation();
            return Balance;
        }

        void PrintInformation()
        {
            Console.WriteLine("Holder's name: " + HolderName);
            Console.WriteLine("Balance: " + Balance);
        }

        void SendEmail()
        {
            Console.WriteLine("Email notification sent");
        }
    }

    public class Student
    {
        public int Grade { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        private string email {  get; set; }
        int age { get; set; }

        public void Register(string Email)
        {
            email = Email;
            SendEmail();
        }

        private void SendEmail()
        {
            Console.WriteLine("Email notification sent");
        }

    }

    public class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        public void Sell(int quantity)
        {
            if (StockQuantity >= quantity)
            {
                StockQuantity -= quantity;
            }
            else
            {
                Console.WriteLine("Not enough stock available!");
            }
            LogTransaction();
        }

        public void Restock(int quantity)
        {
            StockQuantity += quantity;
            LogTransaction();
        }

        public double GetInventoryValue()
        {
            PrintDetails();
            return Price*StockQuantity;
        }

        private void PrintDetails()
        {
            Console.WriteLine($"Product: {ProductName}\nPrice: {Price}\nStock quantity: {StockQuantity}");

        }

        private void LogTransaction()
        {
            Console.WriteLine("Transaction is logged");
        }
    }

    public class Program
    {
        static BankAccount account1 = new BankAccount { AccountNumber = 20213333, HolderName = "Mowadah", Balance = 120 };
        static BankAccount account2 = new BankAccount { AccountNumber = 20224573, HolderName = "Rahma", Balance = 100 };

        static Student student1 = new Student { Name = "Reem", Address = "Muscat", Grade = 98 };
        static Student student2 = new Student { Name = "Sara", Address = "Ibri", Grade = 96 };

        static Product product1 = new Product { ProductName = "Wireless Mouse", Price = 5.500, StockQuantity = 50 };
        static Product product2 = new Product { ProductName = "Mechanical Keyboard", Price = 15.750, StockQuantity = 20 };

        static void Main(string[] args)
        {
            Console.WriteLine("=========== Welcome to the system ===========");

            bool exitApp = false;

            while (exitApp == false)
            {
                Console.WriteLine("\n===== OOP Part 1 - Bank / Student / Product Manager =====");
                Console.WriteLine(" 1. View Account Details");
                Console.WriteLine(" 2. Update Student Address");
                Console.WriteLine(" 3. Make a Deposit");
                Console.WriteLine(" 4. Make a Withdrawal");
                Console.WriteLine(" 5. View Product Details");
                Console.WriteLine(" 6. Register a Student");
                Console.WriteLine(" 7. Compare Two Account Balances");
                Console.WriteLine(" 8. Restock Product & Stock Level Check");
                Console.WriteLine(" 9. Transfer Between Accounts");
                Console.WriteLine("10. Update Student Grade (Validated)");
                Console.WriteLine("11. Student Report Card");
                Console.WriteLine("12. Account Health Status");
                Console.WriteLine("13. Bulk Sale With Revenue Calculation");
                Console.WriteLine("14. Scholarship Eligibility Check");
                Console.WriteLine("15. Full Balance Top-Up Flow");
                Console.WriteLine("16. Quick Account Opening (Parameterized Constructor)");
                Console.WriteLine("17. Total Students Counter (Static Field & Method)");
                Console.WriteLine("18. Overdrawn Account Check (Read-Only Property)");
                Console.WriteLine("19. Set Student Security PIN (Write-Only Property)");
                Console.WriteLine("20. Exit");
                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 20.");
                    continue;
                }

                switch (choice)
                {
                    case 1: ViewAccountDetails(); break;
                    case 2: UpdateStudentAddress(); break;
                    case 3: MakeDeposit(); break;
                    case 4: MakeWithdrawal(); break;
                    case 5: ViewProductDetails(); break;
                    case 6: RegisterStudent(); break;
                    case 7: CompareAccountBalances(); break;
                    case 8: RestockProduct(); break;
                    case 9: TransferBetweenAccounts(); break;
                    case 10: UpdateStudentGrade(); break;
                    case 11: StudentReportCard(); break;
                    case 12: AccountHealthStatus(); break;
                    case 13: BulkSaleWithRevenue(); break;
                    case 14: ScholarshipEligibilityCheck(); break;
                    case 15: FullBalanceTopUpFlow(); break;
                    case 16: QuickAccountOpening(); break;
                    case 17: TotalStudentsCounter(); break;
                    case 18: OverdrawnAccountCheck(); break;
                    case 19: SetStudentSecurityPin(); break;
                    case 20:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 20.");
                        break;
                }

                Console.WriteLine("press any key");
                Console.ReadKey();
                Console.Clear();

            }
        }

        static BankAccount ChooseAccount()
        {
            Console.WriteLine("Choose an account (1 or 2): ");
            string input = Console.ReadLine();
            if (input == "1")
            {
                return account1;
            }
            return account2;
        }

        static Student ChooseStudent()
        {
            Console.WriteLine("Choose a student (1 or 2) ");
            string input = Console.ReadLine();
            if (input == "1")
            {
                return student1;
            }
            return student2;
        }

        static Product ChooseProduct()
        {
            Console.WriteLine("Choose a product  (1 or 2) ");
            string productChoice = Console.ReadLine();
            if (productChoice == "1")
            {
                return product1;
            }
            return product2;
        }

        static void ViewAccountDetails()
        {
            ChooseAccount().CheckBalance();
        }

        static void UpdateStudentAddress()
        {
            Student student = ChooseStudent();
            Console.WriteLine("Enter new address: ");
            string input = Console.ReadLine();
            student.Address = input;
            Console.WriteLine("Address successfully updated!");
            Console.WriteLine("Address updated to: " + student.Address);
        }

        static void MakeDeposit()
        {
            BankAccount account = ChooseAccount();

            Console.Write("Enter amount to deposit: ");
            double amount;
            try
            {
                amount = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid amount.");
                return;   // leave the method — back to the menu
            }

            account.Deposit(amount);
            Console.WriteLine($"{account.HolderName}'s new balance: {account.Balance}");
        }

        static void MakeWithdrawal()
        {
            BankAccount account = ChooseAccount();

            Console.Write("Enter amount to withdraw: ");
            double amount;
            try
            {
                amount = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid amount.");
                return;
            }

            account.Withdraw(amount);
            Console.WriteLine($"Updated balance: {account.Balance}");
        }

        static void ViewProductDetails()
        {
            Product product = ChooseProduct();

            double inventoryValue = product.GetInventoryValue();

            Console.WriteLine($"Total inventory value: {inventoryValue}");
        }

        static void RegisterStudent()
        {
            Student student = ChooseStudent();
            Console.WriteLine("Enter your email: ");
            string email = Console.ReadLine();
            student.Register(email);
            Console.WriteLine($"{student.Name} has been registered successfully.");
        }
    }
}
