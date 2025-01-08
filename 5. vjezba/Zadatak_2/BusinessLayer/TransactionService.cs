using BusinessLayer.Exceptions;
using DAL;
using Entities.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TransactionService
    {
        public List<Transaction> GetAccountTransactions(IAccount account)
        {
            return UnitOfWork.TransactionRepository.GetByAccount(account);
        }

        public List<Transaction> GetTransactions()
        {
            return UnitOfWork.TransactionRepository.GetAll();
        }

        public void MakePayment(IAccount payerAccount, IAccount recieverAccount, double amount)
        {
            var exchangeService = new ExchangeService();

            double amountToPay = amount;
            double amountToRecieve = exchangeService.ChangeMoney(amount, payerAccount.Currency, recieverAccount.Currency);

            var transaction = new Transaction(payerAccount, recieverAccount, amountToPay, amountToRecieve);
            transaction.Execute();

            UnitOfWork.TransactionRepository.Add(transaction);
        }
    }
}
