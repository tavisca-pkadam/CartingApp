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
        [Fact]
        public void TestCreateCartObject()
        {
            var cart = new Cart(DiscountType.FixedDiscount, 100);
            cart.Should().NotBeNull();
        }

        [Fact]
        public void TestAddCartItem()
        {
            var categoryType = Category.Clothing;
            var product = new Product(categoryType)
            {
                name = "Game Of Thrones",
                price = 100
            };

            var cartItem = new CartItem(product);
            cartItem.quantity = 10;

            var cart = new Cart(DiscountType.FixedDiscount, 100);
            cart.AddCartItem(cartItem);


            cart.cartItemList.Count.Should().Be(1);

        }


        [Fact]
        public void TestRemoveCartItem()
        {
            var categoryType = Category.Clothing;
            var product = new Product(categoryType)
            {
                name = "Game Of Thrones",
                price = 100
            };

            var cartItem = new CartItem(product);
            cartItem.quantity = 10;

            var cart = new Cart(DiscountType.FixedDiscount, 100);
            cart.AddCartItem(cartItem);

            cart.RemoveCartItem("Game Of Thrones");
            cart.cartItemList.Count.Should().Be(0);
        }

        [Fact]
        public void TestRemoveCartItemFromEmptyCart()
        {
            var cart = new Cart(DiscountType.FixedDiscount, 100);
            cart.RemoveCartItem("Game Of Thrones");
            cart.cartItemList.Count.Should().Be(0);
        }

        [Fact]
        public void TestGetCartItemByProducName()
        {
            var categoryType = Category.Clothing;
            var product = new Product(categoryType)
            {
                name = "Game Of Thrones",
                price = 100
            };

            var cartItem = new CartItem(product);
            cartItem.quantity = 10;

            var cart = new Cart(DiscountType.FixedDiscount, 100);
            cart.AddCartItem(cartItem);

            cart.GetCartItem(product.name).product.name.Should().Be(product.name);
        }

        [Fact]
        public void TestGetCartItemByProducNameNotAdded()
        {
            var categoryType = Category.Clothing;
            var product = new Product(categoryType)
            {
                name = "Game Of Thrones",
                price = 100
            };

            var cartItem = new CartItem(product);
            cartItem.quantity = 10;

            var cart = new Cart(DiscountType.FixedDiscount, 100);
            cart.AddCartItem(cartItem);

            cart.GetCartItem("abc").Should().BeNull();
        }

        [Fact]
        public void TestChangeProductQuantity()
        {
            var categoryType = Category.Clothing;
            var product = new Product(categoryType)
            {
                name = "Game Of Thrones",
                price = 100
            };

            var cartItem = new CartItem(product);
            cartItem.quantity = 10;

            var cart = new Cart(DiscountType.FixedDiscount, 100);
            cart.AddCartItem(cartItem);

            cart.ChangeProductQuantity("Game Of Thrones", 200);

            cart.GetCartItem("Game Of Thrones").quantity.Should().Be(210);
        }

        [Fact]
        public void TestChangeProductQuantityOfNotAddedProductName()
        {
            var categoryType = Category.Clothing;
            var product = new Product(categoryType)
            {
                name = "Game Of Thrones",
                price = 100
            };

            var cartItem = new CartItem(product);
            cartItem.quantity = 10;

            var cart = new Cart(DiscountType.FixedDiscount, 100);
            cart.AddCartItem(cartItem);

            cart.AddCartItem(cartItem);
            cart.ChangeProductQuantity("Game Of Thrones", 200);
        }


        [Fact]
        public void ListCartItemProductName()
        {
            var categoryType = Category.Clothing;
            var product = new Product(categoryType)
            {
                name = "Game Of Thrones",
                price = 100
            };

            var cartItem = new CartItem(product);
            cartItem.quantity = 10;

            var cart = new Cart(DiscountType.FixedDiscount, 100);
            cart.AddCartItem(cartItem);

            cart.ListCartItemProductName().Find(x => x == product.name).Should().Be("Game Of Thrones");

        }
    }
}
