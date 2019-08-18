using System;
using System.Collections.Generic;
using System.Text;

namespace CartingApp
{
    public class FixedDiscount:IDiscount
    {
        public double DiscountPercentage { get; private set; }

        public FixedDiscount()
        {
            this.DiscountPercentage = 10;
        }

        public double GetDiscountAmount(List<CartItem> cartItems)
        {
            double discountAmount = 0;

            cartItems
                .ForEach(cartItem =>
                {
                    discountAmount += cartItem.product.price - (cartItem.product.price * DiscountPercentage / 100);
                });
            return discountAmount;
        }
    }
}
