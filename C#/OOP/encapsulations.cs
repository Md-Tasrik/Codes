using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BankAccount
{
    private double balance;
    private string AccountHolder;

    public BankAccount(string name, double initialBalance)
    {
        AccountHolder = name;
        if (initialBalance >= 0)
        {
            balance = initialBalance;
        }
        else
        {
            balance = 0;
        }
    }

    public string getAccountHolder()
    {
        return AccountHolder;
    }
    public double getBalance()
    {
        return balance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawal successful. New balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
        else
        {
            Console.WriteLine("Withdrawal amount must be positive.");
        }
    }

   
}



namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            BankAccount account = new BankAccount("Md. Tasrik", 1000);
            account.Deposit(500);
            account.Withdraw(200);
            account.getBalance();
            account.getAccountHolder();
        }
    }
}



