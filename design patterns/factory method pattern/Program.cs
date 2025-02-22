using System;

namespace DesignPatterns.FactoryPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nSelect theme to apply:");
                Console.WriteLine("1. Dark Theme");
                Console.WriteLine("2. Light Theme");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    
                    if (choice == 3)
                    {
                        break;
                    }

                    ThemeFactory factory = choice switch
                    {
                        1 => new DarkThemeFactory(),
                        2 => new LightThemeFactory(),
                        _ => throw new ArgumentException("Invalid choice")
                    };

                    factory.ApplyTheme();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}