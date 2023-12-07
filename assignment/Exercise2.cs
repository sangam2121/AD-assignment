
using System;

class BankAccount
{
    private string accountNumber;
    private decimal balance;

    public BankAccount(string accountNumber)
    {
        this.accountNumber = accountNumber;
        this.balance = 0;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount. Please deposit a positive amount.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn {amount:C}. New balance: {balance:C}");
        }
        else if (amount <= 0)
        {
            Console.WriteLine("Invalid withdrawal amount. Please withdraw a positive amount.");
        }
        else
        {
            Console.WriteLine("Insufficient funds. Withdrawal amount exceeds the balance.");
        }
    }

    public decimal GetBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main()
    {
        BankAccount myAccount = new BankAccount("9899100101");
        myAccount.Deposit(8848);
        myAccount.Withdraw(4484);
        Console.WriteLine($"Final balance: {myAccount.GetBalance():C}");
    }
}

