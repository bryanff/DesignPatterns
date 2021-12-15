using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Product
{
    public class Book : IProduct
    {
        private string _title;
        private double _price;
        public Book(string title, double price)
        {
            _price = price;
            _title = title;
        }
        public double getPrice() => _price;
    }
}
