using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedModels;

namespace MessengerLib
{
    public class Email : IKanal
    {
        public string posaljiPoruku(UserShared user, string poruka)
        {
            if (string.IsNullOrEmpty(user.Email))
            {
                return $"Email not sent to {user.FirstName} + {user.LastName} because no email adress was provided";
            }

            return $"Email sent to {user.Email} with message: {poruka}";
        }
    }
}
