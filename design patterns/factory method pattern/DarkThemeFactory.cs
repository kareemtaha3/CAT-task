namespace DesignPatterns.FactoryPattern
{
    public class DarkThemeFactory : ThemeFactory
    {
        public override ITheme CreateTheme()
        {
            return new DarkTheme();
        }
    }
}