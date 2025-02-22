using System;

namespace DesignPatterns.FactoryPattern
{
    public interface IDatabaseConnectionStrategy {
        public void Connect();
        public void disconnect();
    }
}