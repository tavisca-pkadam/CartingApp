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
            var product = new Product();
            product.name = "Book";
            product.price = 90;
            var cartItem = new CartItem(product);
            cartItem.quantity = 10;

            cartItem.CalculateTotalCost();
            cartItem.totalCost.Should().Be(900);
        }
    }
}
