using DesignPatterns.Strategy.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.sales
{
    public class Order : IOrder
    {
        private List<IProduct> _products = new List<IProduct>();
        public void addProduct(IProduct product) => _products.Add(product);
        public double calculateTotal()
        {
            double total = 0;
            foreach (Book item in _products)
            {
                total += item.getPrice();
            }
            return total;
        }
    }
}
