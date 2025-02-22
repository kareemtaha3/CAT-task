using System;

namespace DesignPatterns.StrategyPattern.PaymentMethods
{
    public class PayPalPayment : IPaymentStrategy
    {
        private string _email;

        public PayPalPayment(string email)
        {
            _email = email;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paying {amount} using PayPal {_email}");
        }
    }
}
