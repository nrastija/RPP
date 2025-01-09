using Entities.Clients;
using Entities.Exchange;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Accounts
{
    public abstract class Account : IAccount
    {
        public string IBAN { get; set; }
        public double Balance { get; set; }

        public virtual double AvailableFunds
        {
            get
            {
                return Balance;
            }
        }

        public AccountType Type { get; set; }
        public Currency Currency { get; set; }

        public IClient Owner { get; set; }

        public Account(string iban, double balance, IClient owner)
        {
            IBAN = iban;
            Balance = balance;
            Owner = owner;
        }

        public virtual void Deposit(double amount)
        {
            double newBalance = Balance + amount;
            Balance = Math.Round(newBalance, 2);
        }

        public virtual void Withdraw(double amount)
        {
            double newBalance = Balance - amount;
            Balance = Math.Round(newBalance, 2);
        }

        public override string ToString()
        {
            return IBAN;
        }
    }
}
