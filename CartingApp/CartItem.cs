using System;
using System.Collections.Generic;
using System.Text;

namespace CartingApp
{
    public class CartItem
    {
        public Product product;
        public int quantity;

        public CartItem(Product product )
        {
            this.product = product;
            quantity = 0;
        }

    }
}
