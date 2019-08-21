using System;
using System.Collections.Generic;
using System.Text;

namespace CartingApp
{

    public class CategoryDiscount : IDiscount
    {
       
        public double GetDiscountAmount(List<CartItem> cartItems)
        {
            double discountAmount = 0;
            cartItems
                .ForEach(cartItem =>
                {
                    discountAmount += cartItem.product.price - (cartItem.product.price * (double)cartItem.product.categoryWithDiscount / 100);

                });
            return discountAmount;
        }
    
    }
}
