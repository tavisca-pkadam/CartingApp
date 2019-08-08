using System;
using System.Collections.Generic;
using System.Text;

namespace CartingApp
{
    public interface IDiscount
    {
        double CalculateDiscountOnPrice(double total);

        void ChangeDiscountValue(double discountValue);

    }
}
