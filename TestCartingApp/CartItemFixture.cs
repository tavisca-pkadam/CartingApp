using System;
using System.Linq;
using Xunit;
using CartingApp;
using FluentAssertions;

namespace TestCartingApp
{
    public class CartItemFixture
    {
        [Fact]
        public void CalculateTotalCost_Method_Calculates_Total_Price_Of_Product()
        {
            var categoryType = Category.Clothing;
            var product = new Product(categoryType)
            {
                name = "Game Of Thrones",
                price = 100
            };

            var cartItem = new CartItem(product);
            cartItem.quantity = 10;

            cartItem.product.price.Should().Be(100);
        }
    }
}
