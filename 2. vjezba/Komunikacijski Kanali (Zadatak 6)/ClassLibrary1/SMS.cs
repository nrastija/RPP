using ClassLibrary1;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerLib
{
    public class SMS : IKanal
    {
        public new string saljiPoruku(User user, string poruka)
        {
            if (!Validacija(user, poruka))
            {
                throw new Exception("Message not sent.");
            }

            return $"SMS sent to {user.Phone} with message: {poruka}";
        }

        protected bool Validacija(User user, string poruka)
        {
            return user != null && !string.IsNullOrWhiteSpace(poruka);
        }
    }
}
