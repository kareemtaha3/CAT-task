using System;
namespace DesignPatterns.FactoryPattern
{
    public class SqlServerStrategy : IDatabaseConnectionStrategy
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to SQL Server database...");
        }
        public void disconnect()
        {
            Console.WriteLine("Disconnecting from SQL Server database...");
        }
    
    }
}