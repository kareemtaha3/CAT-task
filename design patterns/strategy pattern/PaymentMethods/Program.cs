using System;

namespace DesignPatterns.StrategyPattern.PaymentMethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nChoose your payment method:");
                Console.WriteLine("1. Credit Card");
                Console.WriteLine("2. PayPal");
                Console.WriteLine("3. BitCoin");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                
                string choice = Console.ReadLine();
                try
                {
                    if (string.IsNullOrEmpty(choice))
                    {
                    Console.WriteLine("Invalid choice");
                    continue;
                    }

                    if (choice.Equals("4"))
                    {
                    break;
                    }

                    Payer payer = null;
                    switch (choice)
                    {
                        case "1":
                        Console.Write("Enter card number: ");
                            string cardNumber = Console.ReadLine();
                            Console.Write("Enter CVV: ");
                            string cvv = Console.ReadLine();
                            Console.Write("Enter expiry date: ");
                            string expiryDate = Console.ReadLine();
                            payer = new Payer(new CreditCardPayment(cardNumber, cvv, expiryDate));
                            break;
                        case "2":
                             Console.Write("Enter email: ");
                             string email = Console.ReadLine();
                             payer = new Payer(new PayPalPayment(email));
                             break;
                        case "3":
                            Console.Write("Enter wallet address: ");
                            string walletAddress = Console.ReadLine();
                            payer = new Payer(new BitCoinPayment(walletAddress));
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            continue;
                    }

                    Console.Write("Enter amount to pay: ");
                    decimal amount = Convert.ToDecimal(Console.ReadLine());
                    payer.Pay(amount);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid amount format");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
