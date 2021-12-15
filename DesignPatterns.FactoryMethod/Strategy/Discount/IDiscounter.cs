using DesignPatterns.Strategy.sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Discount
{
    public interface IDiscounter
    {
        public void setDiscountStrategy(IDiscount discount);
        public double applyDiscount(IOrder order);
    }
}
