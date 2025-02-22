using System;

namespace DesignPatterns.StrategyPattern.PaymentMethods
{
    public class CreditCardPayment : IPaymentStrategy
    {
        private string _cardNumber;
        private string _cvv;
        private string _expiryDate;

        public CreditCardPayment(string cardNumber, string cvv, string expiryDate)
        {
            _cardNumber = cardNumber;
            _cvv = cvv;
            _expiryDate = expiryDate;
        }

        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paying {amount} using Credit Card {_cardNumber}, {_cvv}, {_expiryDate}");
        }
    }
}
