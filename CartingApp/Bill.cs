using System;
using System.Collections.Generic;
using System.Text;

namespace CartingApp
{
    public class Bill
    {
        const double discountPercentage = 30;
        public double totalBill;
        public double totalBillWithDiscount;

        public Bill()
        {
            totalBill = 0;
            totalBillWithDiscount = 0;
        }

        public void CalculateTotalBill(List<CartItem> cartItemList)
        {
            cartItemList
                .ForEach(x =>
                {
                    x.CalculateTotalCost();
                    totalBill += x.totalCost;
                });
        }

        public void CalculateDiscountBill()
        {
            totalBillWithDiscount = totalBill - (totalBill * discountPercentage / 100);
        }

        
    }
}
