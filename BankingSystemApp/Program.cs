using System;
using System.Collections.Generic;

namespace BankingSystemApp
{
    internal class Program
    {
        // Shared data storage - declared at class level (static) so that
        // EVERY function below can read and modify the same three lists
        // without needing them passed in as parameters.
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();
        static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. List All Accounts");
                Console.WriteLine("7. Close an Account");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue; // skip the rest of this loop pass, show the menu again
                }
                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        ShowBalance();
                        break;
                    case 5:
                        TransferAmount();
                        break;
                    case 6:
                        ListAllAccounts();
                        break;
                    case 7:
                        CloseAccount();
                        break;
                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 8.");
                        break;
                }
            }
        }
        // ===================== SERVICE FUNCTIONS =====================
        // Each function owns ONE service end-to-end: it asks the user for
        // whatever it needs, validates it, updates the shared lists, and
        // prints the outcome. Main never reads input or prints results
        // for these services - it only shows the menu and calls them.
        static void AddAccount()
        {
            Console.WriteLine("Enter your name: ");
            string customerName = Console.ReadLine();

            Console.WriteLine("Enter account number: ");
            string accountNumber = Console.ReadLine();

            if (accountNumbers.Contains(accountNumber))
            {
                Console.WriteLine("Error! the account number is already exists");
                return;
            }

            Console.WriteLine("Enter initial deposit: ");
            if (!double.TryParse(Console.ReadLine(), out double amount))
            {
                Console.WriteLine("Invalid amount. Please enter a number!");
                return;
            }

            if (amount < 0)
            {
                Console.WriteLine("Please enter a positive number");
                return;
            }
            customerNames.Add(customerName);
            accountNumbers.Add(accountNumber);
            balances.Add(amount);

            Console.WriteLine("=====Account Successfully Added=====\n");
            Console.WriteLine($"Customer name: {customerName}");
            Console.WriteLine($"Customer number: {accountNumber}");
            Console.WriteLine($"Customer balance: {amount}");
            Console.WriteLine("\n====================================");
        }
        static void DepositMoney()
        {
            Console.WriteLine("Enter account number: ");
            string accountNumber = Console.ReadLine();
            int index = accountNumbers.IndexOf(accountNumber);

            if (index == -1)
            {
                Console.WriteLine("Account not found!");
                return;
            }

            Console.Write("Enter deposit amount: ");
            if (!double.TryParse(Console.ReadLine(), out double amount))
            {
                Console.WriteLine("Invalid amount. Please enter a number!");
                return;
            }
            if (amount <= 0)
            {
                Console.WriteLine("Please enter a positive number");
                return;
            }
            balances[index] += amount;
            Console.WriteLine($"Deposit successful. {customerNames[index]}'s new balance: {balances[index]}");
        }
        static void WithdrawMoney()
        {
            Console.WriteLine("Enter account number: ");
            string accountNumber = Console.ReadLine();
            int index = accountNumbers.IndexOf(accountNumber);

            if (index == -1)
            {
                Console.WriteLine("Account not found!");
                return;
            }

            Console.Write("Enter withdrawal amount: ");
            if (!double.TryParse(Console.ReadLine(), out double amount))
            {
                Console.WriteLine("Invalid amount. Please enter a number!");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Please enter a positive number");
                return;
            }

            if (amount > balances[index])
            {
                Console.WriteLine($"Insufficient funds. Your balance is {balances[index]}");
                return;
            }

            balances[index] -= amount;
            Console.WriteLine($"Withdrawal successful. {customerNames[index]}'s new balance: {balances[index]}");
        }
        static void ShowBalance()
        {
            Console.WriteLine("Enter account number: ");
            string accountNumber = Console.ReadLine();
            int index = accountNumbers.IndexOf(accountNumber);

            if (index == -1)
            {
                Console.WriteLine("Account not found!");
                return;
            }

            Console.WriteLine("======================================\n");
            Console.WriteLine($"Customer's name: {customerNames[index]}");
            Console.WriteLine($"Customer's account: {accountNumbers[index]}");
            Console.WriteLine($"Customer's balance: {balances[index]}");
            Console.WriteLine("\n====================================");
        }
        static void TransferAmount()
        {
            Console.Write("Enter sender's account number: ");
            string senderAccount = Console.ReadLine();
            int senderIndex = accountNumbers.IndexOf(senderAccount);

            Console.Write("Enter receiver's account number: ");
            string receiverAccount = Console.ReadLine();
            int receiverIndex = accountNumbers.IndexOf(receiverAccount);

            if (senderIndex == -1)
            {
                Console.WriteLine("Sender's account not found!");
                return;
            }

            if (receiverIndex == -1)
            {
                Console.WriteLine("Receiver's account not found!");
                return;
            }

            if (senderIndex == receiverIndex)
            {
                Console.WriteLine("Cannot transfer to the same account.");
                return;
            }

            Console.Write("Enter transfer amount: ");
            if (!double.TryParse(Console.ReadLine(), out double amount))
            {
                Console.WriteLine("Invalid amount. Please enter a number!");
                return;
            }

            if (amount <= 0)
            {
                Console.WriteLine("Please enter a positive number");
                return;
            }

            if (amount > balances[senderIndex])
            {
                Console.WriteLine($"Insufficient funds. Your balance is {balances[senderIndex]}");
                return;
            }

            balances[senderIndex] -= amount;
            balances[receiverIndex] += amount;

            Console.WriteLine("======= Transfer Successful =======");
            Console.WriteLine($"{customerNames[senderIndex]}'s new balance: {balances[senderIndex]}");
            Console.WriteLine($"{customerNames[receiverIndex]}'s new balance: {balances[receiverIndex]}");
            Console.WriteLine("==================================");
        }
        static void ListAllAccounts()
        {
            if (customerNames.Count == 0)
            {
                Console.WriteLine("No accounts have been created yet.");
                return;
            }

            Console.WriteLine("\n========== All Accounts ==========");
            for (int i = 0; i < customerNames.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {customerNames[i]} | {accountNumbers[i]} | {balances[i]}");
            }
            Console.WriteLine($"Total accounts: {customerNames.Count}");
            Console.WriteLine("==================================");
        }
        static void CloseAccount()
        {
            Console.Write("Enter account number to close: ");
            string accountNumber = Console.ReadLine();
            int index = accountNumbers.IndexOf(accountNumber);

            if (index == -1)
            {
                Console.WriteLine("Account not found!");
                return;
            }

            string closingName = customerNames[index];
            double closingBalance = balances[index];

            customerNames.RemoveAt(index);
            accountNumbers.RemoveAt(index);
            balances.RemoveAt(index);

            Console.WriteLine("======= Account Closed =======");
            Console.WriteLine($"Customer: {closingName}");
            Console.WriteLine($"Account: {accountNumber}");
            Console.WriteLine($"Final balance returned: {closingBalance}");
            Console.WriteLine("==============================");
        }
    }
}

