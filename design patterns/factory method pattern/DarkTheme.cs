using System;

namespace DesignPatterns.FactoryPattern
{
    public class DarkTheme : ITheme
    {
        public void SetColor()
        {
            Console.WriteLine("Setting dark colors: Black background, White text");
        }

        public void SetFont()
        {
            Console.WriteLine("Setting dark theme font: Roboto");
        }
    }
}