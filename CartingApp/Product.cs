using System;
using System.Collections.Generic;
using System.Text;

namespace CartingApp
{
    public class Product
    {
        public string name;
        public double price;

        public CategoryWithDiscount categoryWithDiscount;

        public Product(CategoryWithDiscount categoryType)
        {
            this.categoryWithDiscount = categoryType;
        }
    }
}
