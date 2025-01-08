using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Clients
{
    public class BasicClient : Client
    {
        public BasicClient(string oib, string firstName, string lastName)
            : base(oib, firstName, lastName)
        {
            Type = ClientType.Basic;
        }

        public override string Description
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
