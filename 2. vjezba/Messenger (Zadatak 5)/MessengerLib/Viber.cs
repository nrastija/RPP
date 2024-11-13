using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerLib
{
    public class Viber : IKanal
    {
        public string posaljiPoruku(User user, string poruka)
        {
            if (string.IsNullOrEmpty(user.ViberID))
            {
                return $"Viber message was not sent to {user.FirstName} {user.LastName} because no Viber ID was provided.";
            }

            return $"Viber message sent to {user.ViberID} with message: {poruka}";
        }
    }
}
