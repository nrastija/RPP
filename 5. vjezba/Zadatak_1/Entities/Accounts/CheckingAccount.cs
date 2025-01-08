using Entities.Clients;
using Entities.Exchange;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Accounts
{
    public class CheckingAccount : Account
    {
        public override double Overdraft { get; set; }
        public override double AvailableFunds
        {
            get { return CalculateAvailableFunds(); }
        }

        public CheckingAccount(string iban, double balance, double overdraft, Currency currency, IClient owner)
            : base(iban, balance, owner)
        {
            Overdraft = overdraft;
            Type = AccountType.CheckingAccount;
            Currency = currency;
        }

        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }

        private double CalculateAvailableFunds()
        {
            double available = Overdraft + Balance;
            return available;
        }

        public override string ToString()
        {
            return $"IBAN:{IBAN}, Balance:{Balance}, Available funds:{AvailableFunds}";
        }
    }
}
