using System;
namespace DesignPatterns.FactoryPattern

{
    public class PostgressStrategy : IDatabaseConnectionStrategy
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to Postgress database...");
        }
        public void disconnect(){
            Console.WriteLine("Disconnecting from Postgress database...");
        }
    }
}
