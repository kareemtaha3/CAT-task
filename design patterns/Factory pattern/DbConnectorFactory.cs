using System;

namespace DesignPatterns.FactoryPattern
{
    public class DbConnectorFactory
    {
        public static DbConnector GetDbConnector(string dbType)
        {
            IDatabaseConnectionStrategy strategy = dbType.ToLower() switch
            {
                "mysql" => new MySqlStrategy(),
                "postgres" => new PostgressStrategy(),
                "mariadb" => new MariaDBStrategy(),
                "sqlserver" => new SqlServerStrategy(),
                _ => throw new ArgumentException("Invalid database type")
            };

            return new DbConnector(strategy);
        }
    }
}