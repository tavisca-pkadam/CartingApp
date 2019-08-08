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
                .ForEach(x =>
                {
                    discountAmount += x.product.price - (x.product.price * (double)x.product.category / 100);

                });
            return discountAmount;
        }
    
    }
}
