using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
   public class ProductStockRepository
    {
        private static Dictionary<Product, int> _productStockDatabase = Setup();

        private static Dictionary<Product, int> Setup()
        {
            var productStockDatabse = new Dictionary<Product, int>();
            productStockDatabse.Add(Product.Keyboard, 1);
            productStockDatabse.Add(Product.Mic, 1);
            productStockDatabse.Add(Product.Mouse, 1);
            productStockDatabse.Add(Product.Speaker, 1);
            return productStockDatabse;
        }
        public bool IsInStock(Product product)
        {
            Console.WriteLine("Call get on Database");
            return _productStockDatabase [product] > 0;
        }

        public void ReduceStock(Product product)
        {
            Console.WriteLine("Call upadte on Database");
            _productStockDatabase [product] --;
        }

        public void AddStock(Product product)
        {
            Console.WriteLine("Call upadte on Database");
            _productStockDatabase [product]++;
        }
    }
}
