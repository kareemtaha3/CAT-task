namespace DesignPatterns.FactoryPattern
{
    public class LightThemeFactory : ThemeFactory
    {
        public override ITheme CreateTheme()
        {
            return new LightTheme();
        }
    }
}