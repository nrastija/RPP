using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerLib
{
    public class SMS : IKanal
    {
        public string posaljiPoruku(UserShared user, string poruka)
        {
            if (string.IsNullOrEmpty(user.Phone))
            {
                return $"SMS not sent to {user.FirstName} {user.LastName} because no phone number was provided.";
            }

            return $"SMS sent to {user.Phone} with message: {poruka}";
        }
    }
}
