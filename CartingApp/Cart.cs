using System;
using System.Collections.Generic;
using System.Text;

namespace CartingApp
{
    public class Cart
    {
        public List<CartItem> cartItemList;
        public Bill bill;

        public Cart(DiscountType discountType)
        {
            bill = new Bill(discountType);
            cartItemList = new List<CartItem>();
        }

        public void AddProduct(CartItem cartItem)
        {
            cartItemList.Add(cartItem);
        }

        public void RemoveProduct(string productName)
        {
            cartItemList.Remove(
                cartItemList.Find(x => x.product.name == productName)
                );
        }

        public List<string> ListCartItemProductName()
        {
            List<string> cartProductNames = new List<string>();
            cartItemList
                .ForEach(
                    x => cartProductNames.Add(x.product.name)
                );

            return cartProductNames;
        }

        public void ChangeProductQuantity(string productName, int quantity)
        {
            cartItemList
                .Find(x => x.product.name == productName)
                .quantity = quantity;
        }

        public void BillCart()
        {
            bill.CalculateTotalBill(cartItemList);
            bill.CalculateDiscountBill();
        }
    }
}
