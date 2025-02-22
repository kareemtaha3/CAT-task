using System;
namespace DesignPatterns.FactoryPattern{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nChoose database operation:");
                Console.WriteLine("1. Connect to MySQL");
                Console.WriteLine("2. Connect to PostgreSQL");
                Console.WriteLine("3. Connect to MariaDB");
                Console.WriteLine("4. Connect to SQL Server");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    
                    if (choice == 5)
                    {
                        break;
                    }

                    string dbType = choice switch
                    {
                        1 => "mysql",
                        2 => "postgres",
                        3 => "mariadb",
                        4 => "sqlserver",
                        _ => throw new ArgumentException("Invalid choice")
                    };

                    DbConnector dbConnector = DbConnectorFactory.GetDbConnector(dbType);
                    dbConnector.Connect();

                    Console.WriteLine("Press any key to disconnect...");
                    Console.ReadKey();
                    dbConnector.Disconnect();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }

}
