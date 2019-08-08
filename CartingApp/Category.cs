using System;
using System.Collections.Generic;
using System.Text;

namespace CartingApp
{
    public enum CategoryTypes
    {
        dairy,
        entertainment,
        books,
        cloathing
    }

    public class Category
    {
        IDiscount discount;

        public Category(DiscountType discountType )
        {
            discount =  Discount.SelectDiscountType(discountType);
        }
    }
}
