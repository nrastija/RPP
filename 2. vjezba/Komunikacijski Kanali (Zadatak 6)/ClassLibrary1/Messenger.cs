using ClassLibrary1;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerLib
{
    public class Messenger
    {
        private readonly IKanal _kanal;

        public Messenger(IKanal kanal)
        {
            _kanal = kanal;
        }

        public string saljiPoruku(User user, string poruka)
        {
            return _kanal.saljiPoruku(user, poruka);
        }
    }
}
