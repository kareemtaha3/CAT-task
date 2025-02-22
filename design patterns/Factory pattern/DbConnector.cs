using System;
namespace   DesignPatterns.FactoryPattern
{
    public class DbConnector{
        private readonly IDatabaseConnectionStrategy  _strategy;
        public DbConnector(IDatabaseConnectionStrategy strategy){
            _strategy = strategy;
        }
        public void Connect(){
            _strategy.Connect();
        }
        public void Disconnect(){
            _strategy.disconnect();
        }
    }
}
