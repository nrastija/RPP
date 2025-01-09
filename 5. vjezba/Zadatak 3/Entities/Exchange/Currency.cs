using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exchange
{
    public class Currency
    {
        public string Code { get; set; }
        public string Country { get; set; }

        public Currency(string code, string country)
        {
            Code = code;
            Country = country;
        }

        public override string ToString()
        {
            return $"{Code} ({Country})";
        }
    }
}
