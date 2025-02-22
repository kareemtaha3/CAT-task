namespace DesignPatterns.StrategyPattern.PaymentMethods
{
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }
}

