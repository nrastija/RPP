﻿using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerLib
{
    public interface IKanal
    {
        public string posaljiPoruku(UserShared user, String poruka);
    }
}
