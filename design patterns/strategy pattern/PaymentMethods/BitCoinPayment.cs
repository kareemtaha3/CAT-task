using System;

namespace DesignPatterns.StrategyPattern.PaymentMethods
{
	public class BitCoinPayment : IPaymentStrategy
	{
        private string _walletAddress;
        public BitCoinPayment(string WalletAddress)
        {
            _walletAddress = WalletAddress;
        }
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paying {amount} using BitCoin {_walletAddress}");
        }
    }
	

}