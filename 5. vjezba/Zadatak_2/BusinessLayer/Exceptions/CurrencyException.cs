﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Exceptions
{
    public class CurrencyException : BankException
    {
        public CurrencyException(string message) : base(message)
        {

        }
    }
}