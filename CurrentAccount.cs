using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    public class CurrentAccount
    {
        private string? accountNumber, accountHolderName;
        public string AccountNumber
        {
            get { return accountNumber ?? string.Empty; }
            set { accountNumber = value; }
        }
        public string AccountHolderName
        {
            get { return accountHolderName ?? string.Empty; }
            set { accountHolderName = value; }
        }
        public double Balance { get; private set; }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
                return false;
            }
        }
        public void ViewBalance()
        {
            Console.WriteLine($"Balance: {Balance}");
        }
    }
}
