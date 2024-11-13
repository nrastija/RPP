using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace MessengerLib
{
    internal interface IKanal
    {
        public string posaljiPoruku(User user, String poruka);
    }
}
