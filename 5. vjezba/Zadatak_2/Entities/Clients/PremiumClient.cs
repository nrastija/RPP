using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Clients
{
    public class PremiumClient : Client
    {
        public string CompanyName { get; set; }

        public PremiumClient(string oib, string companyName, string firstName, string lastName) : base(oib, firstName, lastName)
        {
            Type = ClientType.Premium;
            CompanyName = companyName;
        }

        public override string Description
        {
            get { return $"{CompanyName}, owner: {FirstName} {LastName}"; }

        }
    }
}
