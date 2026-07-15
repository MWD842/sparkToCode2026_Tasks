using System;

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

        static Student student1 = new Student { Name = "Reem", Address = "Muscat", Grade= 98 };
        static Student student2 = new Student { Name = "Sara", Address = "Ibri", Grade = 96 };

        static Product product1 = new Product { ProductName = "Wireless Mouse", Price = 5.500, StockQuantity = 50 };
        static Product product2 = new Product { ProductName = "Mechanical Keyboard", Price = 15.750, StockQuantity = 20 };

    }
}
