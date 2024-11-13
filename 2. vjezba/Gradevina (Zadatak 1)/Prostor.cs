﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradevina__Zadatak_1_
{
    public abstract class Prostor
    {
        public string Oznaka { get;}
        public decimal Povrsina { get;  }

        public Prostor(String oznaka, Decimal povrsina)
        {
            if (string.IsNullOrEmpty(oznaka))
            {
                throw new ArgumentException("Oznaka ne moze biti prazna.");
            }
            else if (povrsina <= 0)
            {
                throw new ArgumentException("Povrsina ne moze biti manja ili jednaka 0");
            }

            Oznaka = oznaka;
            Povrsina = povrsina;
        }
        public abstract decimal IzracunajNetoPovrsinu();
    }
}
