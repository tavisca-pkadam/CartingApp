using System;
using System.Collections.Generic;
using System.Text;

namespace CartingApp
{
    public interface IDiscount
    {
       double GetDiscountAmount(List<CartItem> cartItems);

    }
}
