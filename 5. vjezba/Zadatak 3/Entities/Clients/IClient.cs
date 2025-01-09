using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Clients
{
    public interface IClient
    {
        string Description { get; }
        ClientType Type { get; }
        string OIB { get; }
        string FirstName { get; }
        string LastName { get; }
    }
}
