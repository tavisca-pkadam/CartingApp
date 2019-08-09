using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CartingApp
{
    public class Invoice
    {
        public double Total { get; private set; }
        public double Discount { get; private set; }
        public double TotalWithDiscount { get; private set; }
        public IDiscount discount;
        public List<CartItem> cartItems;
        public DiscountType DiscountTypeUsed {get; private set;}

        public Invoice(List<CartItem> cartItems, DiscountType discountType)
        {
            Total = 0;
            TotalWithDiscount = 0;
            Discount = 0;
            this.cartItems = cartItems;
            DiscountTypeUsed = discountType;
            discount = DiscountStrategy.GetInstance(discountType);
        }

        public void Update()
        {
           
            CalculateTotal();
            CalculateDiscount();
            CalculateDiscountedTotal();
           
        }

        public void CalculateTotal()
        {
            cartItems
                .ForEach(x =>
                {
                    Total += (x.product.price * x.quantity);
                });
        }

        public void CalculateDiscount()
        {
            Discount = discount.GetDiscountAmount(cartItems);
        }

        public void CalculateDiscountedTotal()
        {
            TotalWithDiscount = Total - Discount;
        }
    }
}
