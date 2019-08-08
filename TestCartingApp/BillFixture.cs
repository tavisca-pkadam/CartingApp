using System;
using System.Linq;
using Xunit;
using CartingApp;
using FluentAssertions;
using System.Collections.Generic;

namespace TestCartingApp
{
    public class BillFixture
    {
        Cart cart;
        Bill bill;

        public BillFixture()
        {
            cart = new Cart();
            bill = new Bill();
        }

        [Fact]
        public void TestCalculateTotalBill()
        {
            var product = new Product();
            product.name = "Book";
            product.price = 90;
            var cartItem = new CartItem(product);
            cartItem.quantity = 10;

            List<CartItem> cartItemList = new List<CartItem>();
            cartItemList.Add(cartItem);

            bill.CalculateTotalBill(cartItemList);
            bill.CalculateDiscountBill();

            bill.totalBill.Should().Be(900);
        }

        [Fact]
        public void TestCalculateDiscountBill()
        {
            var product = new Product();
            product.name = "Book";
            product.price = 90;
            var cartItem = new CartItem(product);
            cartItem.quantity = 10;

            List<CartItem> cartItemList = new List<CartItem>();
            cartItemList.Add(cartItem);

            bill.CalculateTotalBill(cartItemList);
            bill.CalculateDiscountBill();
            bill.totalBillWithDiscount.Should().Be(630.0);
            
        }
    }
}
