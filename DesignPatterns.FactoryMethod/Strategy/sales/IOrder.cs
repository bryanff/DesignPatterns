using DesignPatterns.Strategy.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.sales
{
    public interface IOrder
    {
        public void addProduct(IProduct product);
        public double calculateTotal();
    }
}
