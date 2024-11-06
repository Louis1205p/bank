using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Account
    {
        private decimal balance;
        public Account(decimal initialDeposit)
        {
            if (initialDeposit < 100)
            {
                Console.WriteLine("must be at least 100.");
                balance = 100;
            }
            else
            {
                balance = initialDeposit;
            }
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
                Console.WriteLine("You must withdraw a number within you balance");
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
