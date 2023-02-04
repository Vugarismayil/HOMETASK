using System;
using System.Collections.Generic;
using System.Text;

namespace HometaskPolymorphism
{
    internal class Dairy : Store
    {
        public double FatPercent;
        public static explicit operator Dairy(Product v)
        {
            throw new NotImplementedException();
        }
    }
}
