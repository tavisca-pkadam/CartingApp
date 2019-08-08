using System;
using System.Collections.Generic;
using System.Text;

namespace CartingApp
{
    public class CartItem
    {
        public Product product;
        public int quantity;
        public  double totalCost;
        public double totalCostOnDiscount;

        public IDiscount discount;

        public CartItem(Product product ,DiscountType discountType)
        {
            this.product = product;
            quantity = 0;
            totalCost = 0;
            discount = Discount.SelectDiscountType(discountType);
        }


        public void CalculateTotalCost()
        {
            discount.CalculateDiscountOnPrice()
            this.totalCost = this.product.price * this.quantity;
        }

       
    }
}
