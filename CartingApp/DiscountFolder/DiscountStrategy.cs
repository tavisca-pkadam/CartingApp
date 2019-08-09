using System;
using System.Collections.Generic;
using System.Text;

namespace CartingApp
{
    public enum DiscountType
    {
        FixedDiscount,
        VariableDiscount,
        CategoryDiscount
    }

    public static class DiscountStrategy
    {
        public static IDiscount GetInstance(DiscountType discountType)
        {
            if (discountType == DiscountType.CategoryDiscount)
            {
                return new CategoryDiscount();
            }
            if (discountType == DiscountType.VariableDiscount)
            {
                return new VariableDiscount();
            }
            if (discountType == DiscountType.FixedDiscount)
            {
                return new FixedDiscount();
            }
            return new FixedDiscount();

        }
    }
}
