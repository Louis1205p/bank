using Bank2;
using System;

namespace Bank
{
    public class AccountAdmin : Person
    {
        public int EmployeeId { get; private set; }

        public AccountAdmin(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            Random rand = new Random();
            EmployeeId = rand.Next(100000, 1000000);
        }
    }
}
