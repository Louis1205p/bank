using Bank2;
using System;

namespace Bank
{
    public class AccountOwner : Person
    {
        public int AccountOwnerId { get; private set; }

        public AccountOwner(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            Random rand = new Random();
            AccountOwnerId = rand.Next(100000, 1000000);
        }
    }
}
