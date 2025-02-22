using System;

namespace DesignPatterns.BuilderPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var assembler = new ComputerAssembler();

            while (true)
            {
                Console.WriteLine("\nSelect computer type to build:");
                Console.WriteLine("1. Gaming Computer");
                Console.WriteLine("2. Office Computer");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    
                    if (choice == 3)
                    {
                        break;
                    }

                    IComputerBuilder builder = choice switch
                    {
                        1 => new GamingComputerBuilder(),
                        2 => new OfficeComputerBuilder(),
                        _ => throw new ArgumentException("Invalid choice")
                    };

                    assembler.SetBuilder(builder);
                    assembler.ConstructComputer();
                    Computer computer = assembler.GetComputer();
                    computer.DisplayConfiguration();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}