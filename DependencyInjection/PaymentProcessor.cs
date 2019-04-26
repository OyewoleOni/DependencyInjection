using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public interface IPaymentProcessor
    {
        void ChargeCreditCard(string creditCardNumber, string expiryDate);
    }
   public class PaymentProcessor : IPaymentProcessor
    {
        public void ChargeCreditCard(string creditCardNumber, string expiryDate)
        {
            if ( string.IsNullOrEmpty(creditCardNumber) )
            {
                throw new ArgumentException("Invalid Credit Card", nameof(creditCardNumber));
            }


            if ( string.IsNullOrEmpty(expiryDate) )
            {
                throw new ArgumentException("message", nameof(creditCardNumber));
            }

            Console.WriteLine("Call to Credit Card API");
        }
    }
}
