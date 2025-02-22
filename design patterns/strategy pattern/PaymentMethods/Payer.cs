using System;


namespace DesignPatterns.StrategyPattern.PaymentMethods
{
    public class Payer
    {
        private IPaymentStrategy _paymentStrategy;
        public Payer(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }
        public void Pay(decimal amount)
        {
            _paymentStrategy.Pay(amount);
        }
    }
}

