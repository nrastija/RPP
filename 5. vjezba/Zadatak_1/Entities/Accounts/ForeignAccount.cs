using Entities.Clients;
using Entities.Exchange;

namespace Entities.Accounts
{
    public class ForeignAccount : Account
    {
        public ForeignAccount(string iban, double balance, Currency currency, IClient owner) : base(iban, balance, owner)
        {
            Currency = currency;
            Type = AccountType.ForeignAccount;
        }

        public override string ToString()
        {
            return $"IBAN:{IBAN}, Balance:{Balance}, Available Funds: {AvailableFunds}, Valuta:{Currency.Code}";
        }
    }
}
