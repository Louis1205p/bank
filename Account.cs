using Bank2;
using System;

namespace Bank
{
    public class Account
    {
        private decimal balance;
        public int AccountId { get; private set; }
        public Person AccountOwner { get; private set; }
        public Person AccountAdmin { get; private set; }

        public Account(Person accountOwner, Person accountAdmin, decimal initialDeposit)
        {
            AccountOwner = accountOwner;
            AccountAdmin = accountAdmin;

            Random rand = new Random();
            AccountId = rand.Next(100000, 1000000);

            if (initialDeposit < 100)
            {
                Console.WriteLine("Initial deposit must be at least 100.");
                balance = 100;
            }
            else
            {
                balance = initialDeposit;
            }

            Console.WriteLine($"Account created for {AccountOwner.FullName} with admin {AccountAdmin.FullName}.");
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("You must deposit a positive amount.");
                return;
            }
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("You must withdraw a positive amount.");
                return;
            }
            if (amount > balance)
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }
            balance -= amount;
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Balance: {balance:C}");
        }
    }
}
