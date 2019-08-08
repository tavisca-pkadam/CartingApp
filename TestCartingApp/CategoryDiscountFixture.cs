using System;
using System.Linq;
using Xunit;
using CartingApp;
using FluentAssertions;
using System.Collections.Generic;

namespace TestCartingApp
{
    public class CategoryDiscountFixture
    {
         List<CartItem> cartItems;

        public CategoryDiscountFixture()
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
        public void TestGetDiscountAmount()
        {
            var categoryDiscount = new CategoryDiscount();

            categoryDiscount.GetDiscountAmount(cartItems).Should().Be(90);
        }
    }
}
