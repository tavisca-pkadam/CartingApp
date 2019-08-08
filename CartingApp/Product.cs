using System;
using System.Collections.Generic;
using System.Text;

namespace CartingApp
{
    public class Product
    {
        public string name;
        public double price;
        public double dicountedPrice;

        IDiscount discount;

        public Product(DiscountType discountType)
        {
            discount = Discount.SelectDiscountType(discountType);
        }

        public void CalculateDiscount(double discountValue)
        {
            this.dicountedPrice = discount.CalculateDiscountOnPrice(price);
        }
    }
}
