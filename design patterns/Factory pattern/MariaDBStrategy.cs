using System;
namespace   DesignPatterns.FactoryPattern
{
    public class MariaDBStrategy : IDatabaseConnectionStrategy
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to MariaDB database...");
        }
        public void disconnect(){
            Console.WriteLine("Disconnecting from MariaDB database...");
        }
    }
}