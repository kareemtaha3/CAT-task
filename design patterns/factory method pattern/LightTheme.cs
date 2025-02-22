using System;

namespace DesignPatterns.FactoryPattern
{
    public class LightTheme : ITheme
    {
        public void SetColor()
        {
            Console.WriteLine("Setting light colors: White background, Black text");
        }

        public void SetFont()
        {
            Console.WriteLine("Setting light theme font: Arial");
        }
    }
}