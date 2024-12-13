using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Cache
    {
        private double? cach;
        Drobi d;
        public Cache(Drobi d)
        {
            this.cach = null;
         this.d = d;
        }

        public double GetValue()
        {
            if (cach == null)
            {
                cach = (double) d.Numerator/d.Denominator;
            }
            return (double)cach;
        }

        public void SetNumerator(int numerator)
        {
            d.Numerator = numerator;
            cash = null; // Сбросить кэш
        }

        public void SetDenominator(int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменатель не может быть равен нулю.");
            d.denominator = denominator;
            cash = null; // Сбросить кэш
        }
    }
}
