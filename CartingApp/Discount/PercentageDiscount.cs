using System;
using System.Collections.Generic;
using System.Text;

namespace CartingApp
{
    public class PercentageDiscount:IDiscount
    {
        public double DiscountPercentage { get; set; }

        public PercentageDiscount(int discountPercentage)
        {
            DiscountPercentage = discountPercentage;
        }

        public double CalculateDiscountOnPrice(double total)
        {
            return total - (total * DiscountPercentage / 100);
        }

        public void ChangeDiscountValue(double discountValue)
        {
            DiscountPercentage = discountValue;
        }


    }
}
