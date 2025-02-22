using System;
namespace   DesignPatterns.FactoryPattern
{
    public class MySqlStrategy : IDatabaseConnectionStrategy
    {
        public void Connect()
        {
                Console.WriteLine("Connecting to MySql database...");
        }
        public void disconnect(){
            Console.WriteLine("Disconnecting from MySQL database...");
        }
    }
}