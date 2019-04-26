using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public interface IOrderManager
    {
        void Submit(Product product, string creditCardNumber, string expiryDate);
    }
   public  class OrderManager : IOrderManager
    {
        public void Submit(Product product, string creditCardNumber, string expiryDate)
        {
            // Check product stock
            var productStockRepository = new ProductStockRepository();
            if ( !productStockRepository.IsInStock(product) )
                throw new Exception($"{product.ToString()} currently not in stock");
            // Payment
            var paymentProcessor = new PaymentProcessor();
            paymentProcessor.ChargeCreditCard(creditCardNumber, expiryDate);

            // Ship the product
            var shippingProcessor = new ShippingProcessor();
            shippingProcessor.MailProduct(product);
        }
    }
}
