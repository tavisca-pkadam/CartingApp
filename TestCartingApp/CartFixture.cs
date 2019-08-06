using System;
using System.Linq;
using Xunit;
using CartingApp;
using System.Linq.Expressions;
using FluentAssertions;

namespace TestCartingApp
{
    public class CartFixture
    {
        Cart cart;

        public CartFixture()
        {
            cart = new Cart();   
        }
        [Fact]
        public void TestAddProduct()
        {
            var product = new Product();
            product.name = "Book";
            product.price = 90;
            var cartItem = new CartItem(product);
            cartItem.quantity = 10;

            cart.AddProduct(cartItem);


            cart.cartItemList.Count.Should().Be(1);

        }

        [Fact]
        public void TestRemoveProduct()
        {
            var product = new Product();
            product.name = "Book";
            product.price = 90;
            var cartItem = new CartItem(product);
            cartItem.quantity = 10;

            cart.AddProduct(cartItem);
            cart.RemoveProduct("Book");

            cart.cartItemList.Count.Should().Be(0);
        }

        [Fact]
        public void TestChangeProductQuantity()
        {
            var product = new Product();
            product.name = "Book";
            product.price = 90;
            var cartItem = new CartItem(product);
            cartItem.quantity = 10;

            cart.AddProduct(cartItem);
            cart.ChangeProductQuantity("Book", 200);
        }

        [Fact]
        public void TestBillCart()
        {
            var product = new Product();
            product.name = "Book";
            product.price = 90;
            var cartItem = new CartItem(product);
            cartItem.quantity = 10;

            cart.AddProduct(cartItem);

            cart.BillCart();
            cart.bill.totalBill.Should().Be(900);
        }

        [Fact]
        public void ListCartItemProductName()
        {
            var product = new Product();
            product.name = "Book";
            product.price = 90;
            var cartItem = new CartItem(product);
            cartItem.quantity = 10;

            cart.AddProduct(cartItem);

            cart.ListCartItemProductName().Find(x => x == product.name).Should().Be("Book");

        }
    }
}
