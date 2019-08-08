using System;
using System.Linq;
using Xunit;
using CartingApp;
using FluentAssertions;
using System.Collections.Generic;

namespace TestCartingApp
{
    public class FixedDiscountFixture
    {
         List<CartItem> cartItems;

        public FixedDiscountFixture()
        {
            var categoryType = Category.Clothing;
            var product = new Product(categoryType)
            {
                name = "Game Of Thrones",
                price = 100
            };

            var cartItem = new CartItem(product);
            cartItem.quantity = 10;

            cartItems = new List<CartItem>();
            cartItems.Add(cartItem);
        }

        [Fact]
        public void TestGetDiscountPercentage()
        {
            var fixedDiscount = new FixedDiscount();

            fixedDiscount.DiscountPercentage.Should().Be(10);
        }

        
        [Fact]
        public void TestGetDiscountAmount()
        {
            var fixedDiscount = new FixedDiscount();

            fixedDiscount.GetDiscountAmount(cartItems).Should().Be(90);
        }
    }
}
