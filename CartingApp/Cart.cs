﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CartingApp
{
    public class Cart
    {
        public List<CartItem> cartItemList { get; private set; }
        public Invoice invoice;

        public Cart(DiscountType discountType, double discount)
        {
            cartItemList = new List<CartItem>();
            invoice = new Invoice(this.cartItemList, DiscountType.CategoryDiscount);
        }

        public void AddCartItem(CartItem cartItem)
        {
            cartItemList.Add(cartItem);
        }

        public void RemoveCartItem(string productName)
        {
            try
            {
                cartItemList.Remove(
                    cartItemList.Find(cartItem => cartItem.product.name == productName)
                );
            }
            catch (System.Exception)
            {

            }
        }

        public CartItem GetCartItem(string productName)
        {
            try
            {
                return cartItemList.Find(cartItem => cartItem.product.name == productName);

            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public List<string> ListCartItemProductName()
        {
            List<string> cartProductNames = new List<string>();

            cartItemList
                .ForEach(
                    cartItem => cartProductNames.Add(cartItem.product.name)
                );
            return cartProductNames;
        }

        public void ChangeProductQuantity(string productName, int quantity)
        {
            try
            {
                cartItemList
                .Find(cartItem => cartItem.product.name == productName)
                .quantity += quantity;
            }
            catch (System.Exception)
            {
            }
            
        }

    }
}
