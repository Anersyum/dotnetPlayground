﻿using DotNetPlayground.Classes;
using DotNetPlayground.Interfaces;

namespace DotNetPlayground.Servisi
{
    public class SaberiDvaBrojaServis_Z1 :IKalkulator_Z1 
    {
        public int kalkulisi(Saberi_Z1 broj)
        {
            return broj.broj1 + broj.broj2;
        }
    }
}
