
using Bank;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your first name to start creating your account:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter your last name:");
        string lastName = Console.ReadLine();

        Random rand = new Random();
        int accountId = rand.Next(100000, 1000000);

        Console.WriteLine($"Account Owner: {firstName} {lastName}");
        Console.WriteLine($"Account ID: {accountId}");

        Console.Write("Make your first deposit (minimum 100,-): ");
        decimal initialDeposit = Convert.ToDecimal(Console.ReadLine());

        Account myAccount = new Account(initialDeposit);

        myAccount.ShowBalance();

        bool running = true;
        while (running)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Deposit Money");
            Console.WriteLine("2. Withdraw Money");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the amount you wish to deposit: ");
                    decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                    myAccount.Deposit(depositAmount);
                    break;

                case "2":
                    Console.Write("Enter the amount you wish to withdraw: ");
                    decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                    myAccount.Withdraw(withdrawAmount);
                    break;

                case "3":
                    myAccount.ShowBalance();
                    break;

                case "4":
                    Console.WriteLine("Exiting");
                    running = false;
                    break;

                default:
                    Console.WriteLine("try again.");
                    break;
            }
        }

        Console.ReadKey();
    }
}
