using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exchange
{
    class ExchangeRate
    {
        public Currency Currency { get; set; }
        public double Rate { get; set; }

        public ExchangeRate(Currency currency, double rate)
        {
            Currency = currency;
            Rate = rate;
        }
    }
}
