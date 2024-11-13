using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace ClassLibrary1
{
    public interface IKanal
    {
        string saljiPoruku(User user, string poruka);
    }
}
