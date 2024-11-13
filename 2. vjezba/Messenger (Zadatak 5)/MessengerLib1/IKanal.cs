using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerLib
{
    public interface IKanal
    {
         string posaljiPoruku(User user, String poruka);
    }
}
