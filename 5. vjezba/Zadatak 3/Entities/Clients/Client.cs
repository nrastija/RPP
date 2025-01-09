using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Clients
{
    public abstract class Client : IClient
    {
        public abstract string Description { get; }
        public ClientType Type { get; set; }
        public string OIB { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Client(string oib, string firstName, string lastName)
        {
            OIB = oib;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
