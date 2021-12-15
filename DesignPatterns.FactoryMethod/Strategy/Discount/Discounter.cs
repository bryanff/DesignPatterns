using DesignPatterns.Strategy.sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Discount
{
    public class Discounter : IDiscounter
    {
        private IDiscount _discountStrategy;
        public double applyDiscount(IOrder order)
        {
            return this._discountStrategy.applyDiscount(order.calculateTotal());
        }
        public void setDiscountStrategy(IDiscount discount)
        {
            this._discountStrategy = discount;
        }
    }
}
