using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Discount
{
    public class DiscountForTeacher : IDiscount
    {
        private double _discount;
        public DiscountForTeacher(double discount) => _discount = discount;
        public double applyDiscount(double sale_price)
        {
            return (sale_price - _discount);
        }
    }
}
