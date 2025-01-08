using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class UnitOfWork
    {
        private static AccountRepository accountRepository;

        public static AccountRepository AccountRepository 
        {
            get
            {
                if(accountRepository == null)
                {
                    accountRepository = new AccountRepository();
                }
                return accountRepository;
            }
        }
        private static ClientRepository clientRepository;

        public static ClientRepository ClientRepository
        {
            get
            {
                if(clientRepository == null)
                {
                    clientRepository = new ClientRepository();
                }
                return clientRepository;
            }
        }

        private static TransactionRepository transactionRepository;

        public static TransactionRepository TransactionRepository
        {
            get
            {
                if(transactionRepository == null)
                {
                    transactionRepository = new TransactionRepository();
                }
                return transactionRepository;
            }
        }

        private static CurrencyRepository currencyRepository;

        public static CurrencyRepository CurrencyRepository
        {
            get
            {
                if(currencyRepository == null)
                {
                    currencyRepository = new CurrencyRepository();
                }
                return currencyRepository;
            }
        }

        private static ExchangeRateRepository exchangeRateRepository;

        public static ExchangeRateRepository ExchangeRateRepository
        {
            get
            {
                if(exchangeRateRepository == null)
                {
                    exchangeRateRepository = new ExchangeRateRepository();
                }
                return exchangeRateRepository;
            }
        }
    }
}
