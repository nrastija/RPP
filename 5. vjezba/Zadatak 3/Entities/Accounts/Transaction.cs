using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Accounts
{
    public class Transaction
    {
        public int Id { get; set; }
        [Browsable(false)]
        public IAccount PayerAccount { get; set; }
        [Browsable(false)]
        public IAccount ReceiverAccount { get; set; }

        public string PayerAccountDescription
        {
            get
            {
                if (PayerAccount != null)
                {
                    return PayerAccount.ToString();
                }
                return "";
            }
        }

        public string ReceiverAccountDescription
        {
            get
            {
                if (ReceiverAccount != null)
                {
                    return ReceiverAccount.ToString();
                }
                return "";
            }
        }

        private double _amountPayed;

        public double AmountPayed
        {
            get { return _amountPayed; }
            set { _amountPayed = Math.Round(value, 2); }
        }

        private double _amountReceived;

        public double AmountReceived
        {
            get { return _amountReceived; }
            set { _amountReceived = Math.Round(value, 2); }
        }


        public bool Completed { get; set; }
        public DateTime Date { get; set; }

        public Transaction(IAccount payerAccount, IAccount receiverAccount, double amountToPay, double amountToReceive)
        {
            Id = GetHashCode();
            PayerAccount = payerAccount;
            ReceiverAccount = receiverAccount;
            AmountPayed = amountToPay;
            AmountReceived = amountToReceive;
            Date = DateTime.Now;

            Completed = false;
        }

        public void Execute()
        {
            PayerAccount.Withdraw(AmountPayed);
            ReceiverAccount.Deposit(AmountReceived);

            Completed = true;
        }

        public void Cancel()
        {
            PayerAccount.Deposit(AmountPayed);
            ReceiverAccount.Withdraw(AmountReceived);
        }
    }
}
