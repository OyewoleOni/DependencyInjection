using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
   public class ShippingProcessor : IShippingProcessor
    {
        public void MailProduct(Product product)
        {
            var productStockRepository = new ProductStockRepository();
            productStockRepository.ReduceStock(product);

            Console.WriteLine("Call to Shipping API");
        }
    }
}
