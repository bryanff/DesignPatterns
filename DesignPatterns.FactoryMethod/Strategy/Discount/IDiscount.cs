using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Discount
{
    public interface IDiscount
    {
        public double applyDiscount(double sale_price);
    }
}
