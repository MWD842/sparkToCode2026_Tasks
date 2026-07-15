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
            if (Balance < amount)
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
        
    }

    public class Program
    {

    }
}
