using System;
using System.Collections.Generic;
using System.Text;

namespace CartingApp
{
    public class CartItem
    {
        public Product product;
        public int quantity;
        public  double totalCost;

        public CartItem(Product product)
        {
            this.product = product;
            quantity = 0;
            totalCost = 0;
        }

        public void CalculateTotalCost()
        {
            this.totalCost = this.product.price * this.quantity;
        }

       
    }
}
