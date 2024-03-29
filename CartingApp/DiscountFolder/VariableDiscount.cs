﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CartingApp
{
    public class VariableDiscount: IDiscount
    {
        public double DiscountPercentage { get; private set; }

        public VariableDiscount()
        {

            DiscountPercentage = Configuration.GetConfigurationDiscount();
        }

        public double GetDiscountAmount(List<CartItem> cartItems)
        {
            double discountAmount = 0;

            cartItems
                .ForEach(cartItem =>
                {
                    discountAmount += cartItem.product.price - (cartItem.product.price * (double)DiscountPercentage / 100);

                });
            return discountAmount;
        }



    }
}
