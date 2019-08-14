using System;
using System.Collections.Generic;
using System.Text;
using CartingApp;
using Xunit;
using FluentAssertions;

namespace TestCartingApp
{
    public class ProductFixture
    {
        [Fact]
        public void Test_Creating_Product_Object_With_Category()
        {
            var categoryType = CategoryWithDiscount.Clothing;
            var product = new Product(categoryType)
            {
                name = "Game Of Thrones",
                price = 100
            };
            product.categoryWithDiscount.Should().Be(categoryType);
        }

    }
}
