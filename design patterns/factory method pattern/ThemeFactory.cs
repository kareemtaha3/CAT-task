using System;

namespace DesignPatterns.FactoryPattern
{
    public abstract class ThemeFactory
    {
        public abstract ITheme CreateTheme();

        public void ApplyTheme()
        {
            ITheme theme = CreateTheme();
            theme.SetColor();
            theme.SetFont();
        }
    }
}