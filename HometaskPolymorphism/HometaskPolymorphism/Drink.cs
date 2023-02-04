using System;
using System.Collections.Generic;
using System.Text;

namespace HometaskPolymorphism
{
    internal class Drink : Store
    {
        public double AlcoholPercent;

        public static explicit operator Drink(Product v)
        {
            throw new NotImplementedException();
        }
    }
}
