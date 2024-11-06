using System;
using Bank;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the account owner's first name:");
        string ownerFirstName = Console.ReadLine();

        Console.WriteLine("Enter the account owner's last name:");
        string ownerLastName = Console.ReadLine();

        Console.WriteLine("Enter the admin's first name:");
        string adminFirstName = Console.ReadLine();

        Console.WriteLine("Enter the admin's last name:");
        string adminLastName = Console.ReadLine();

        Console.WriteLine("Enter the initial deposit (minimum 100):");
        decimal initialDeposit = Convert.ToDecimal(Console.ReadLine());

        AccountOwner accountOwner = new AccountOwner(ownerFirstName, ownerLastName);
        AccountAdmin accountAdmin = new AccountAdmin(adminFirstName, adminLastName);

        Console.WriteLine($"Account Owner ID: {accountOwner.AccountOwnerId}");
        Console.WriteLine($"Account Admin Employee ID: {accountAdmin.EmployeeId}");

        Account account = new Account(accountOwner, accountAdmin, initialDeposit);

        account.ShowBalance();

        Console.WriteLine("Deposit 200:");
        account.Deposit(200);
        account.ShowBalance();

        Console.WriteLine("Withdraw 50:");
        account.Withdraw(50);
        account.ShowBalance();

        Console.ReadKey();
    }
}