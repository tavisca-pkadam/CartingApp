using System;
using System.Collections.Generic;
using System.Text;

namespace CartingApp
{
    public class Product
    {
        public string name;
        public double price;

        public Category category;

        public Product(Category categoryType)
        {
            this.category = categoryType;
        }
    }
}
