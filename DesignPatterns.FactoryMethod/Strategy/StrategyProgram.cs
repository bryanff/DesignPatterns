using DesignPatterns.Strategy.Discount;
using DesignPatterns.Strategy.Product;
using DesignPatterns.Strategy.sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class StrategyProgram
    {
        public static void Run()
        {
            IProduct clean_code = new Book("Clean Code", 30.0);
            IProduct coquito = new Book("Coquito", 10.0);

            IOrder order = new Order();
            order.addProduct(clean_code);
            order.addProduct(coquito);

            IDiscounter discounter = new Discounter();
            IDiscount discount = new DiscountForStudent(20);
            IDiscount discountteacher = new DiscountForTeacher(0);

            discounter.setDiscountStrategy(discount);
            double price_after_discount = discounter.applyDiscount(order);
            Console.WriteLine(
                " Total Price: " + order.calculateTotal() +
                "\n Total Price After Discount: " + price_after_discount
            );
        }
    }
    
   
    
  
    
    
    
    
   
}
