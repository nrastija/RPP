using ClassLibrary1;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MessengerLib
{
    public class Email : IKanal
    {
        public string saljiPoruku(User user, string poruka)
        {
            if (!Validacija(user, poruka))
            {
                throw new Exception("Message not sent.");
            }
            
            return $"Email sent to {user.Email} with message: {poruka}";

        }

        protected virtual bool Validacija(User user, string poruka)
        {
            return user != null && !string.IsNullOrWhiteSpace(poruka);
        }
    }
}
