using System;
using System.Linq;
using Xunit;
using CartingApp;
using FluentAssertions;
using System.Collections.Generic;

namespace TestCartingApp
{
    public class InvoiceFixture
    {
        List<CartItem> cartItems;

        public InvoiceFixture()
        {
            var categoryType = CategoryWithDiscount.Clothing;
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
        public void TestCreatingInvoiceWithFixedDiscount()
        {
            var invoice = new Invoice(cartItems, DiscountType.FixedDiscount);
            invoice.Should().NotBeNull();
        }

        [Fact]
        public void TestCalculateTotalBill()
        {
            var invoice = new Invoice(cartItems, DiscountType.FixedDiscount);
            invoice.CalculateTotal();
            invoice.Total.Should().Be(1000);
        }

        [Fact]
        public void TestCalculateDiscount()
        {
            var invoice = new Invoice(cartItems, DiscountType.FixedDiscount);
            invoice.CalculateDiscount();
            invoice.Discount.Should().Be(90);
        }

        [Fact]
        public void TestCalculateDiscountedTotal()
        {
            var invoice = new Invoice(cartItems, DiscountType.FixedDiscount);

            invoice.CalculateTotal();
            invoice.CalculateDiscount();
            invoice.CalculateDiscountedTotal();

            invoice.TotalWithDiscount.Should().Be(910);
        }

        
    }
}
