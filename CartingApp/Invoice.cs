﻿using System;
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
                .ForEach(cartItem =>
                {
                    Total += (cartItem.product.price * cartItem.quantity);
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
