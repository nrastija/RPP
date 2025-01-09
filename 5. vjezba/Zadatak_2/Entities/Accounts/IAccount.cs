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
    public enum AccountState
    {
        Active, Inactive
    }

    public interface IAccount
    {
        string IBAN { get; }
        double Balance { get; }

        double AvailableFunds { get; }

        AccountType Type { get; }
        Currency Currency { get; }

        [Browsable(false)]
        IClient Owner { get; set; }

        void Deposit(double amount);
        void Withdraw(double amount);
    }
}
