﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trasporto
{
    internal interface Alimentazione :Benzzina
    {
        void Carburante( Alimentazione alimentazione);
    }
}