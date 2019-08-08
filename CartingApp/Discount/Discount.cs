using System;
using System.Collections.Generic;
using System.Text;

namespace CartingApp
{
    public enum DiscountType
    {
        FixedAmountDiscount,
        PercentageDiscount
    }
    public class Discount
    {
            public static IDiscount SelectDiscountType(DiscountType discountType)
        {
            if(discountType == DiscountType.FixedAmountDiscount)
            {
                return new FixedAmountDiscount(0);
            }
            if (discountType == DiscountType.FixedAmountDiscount)
            {
                return new PercentageDiscount(0);
            }
            return new PercentageDiscount(0);
        }
    }
}
