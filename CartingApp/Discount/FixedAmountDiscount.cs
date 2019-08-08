using System;
using System.Collections.Generic;
using System.Text;

namespace CartingApp
{
    public class FixedAmountDiscount:IDiscount
    {
        public double discountAmount { get; set; }

        public FixedAmountDiscount(double discountAmount)
        {
            this.discountAmount = discountAmount;
        }

        public double CalculateDiscountOnPrice(double total)
        {
            return total - discountAmount;
        }

        public void ChangeDiscountValue(double discountValue)
        {
            discountAmount = discountValue;
        }
    }
}
