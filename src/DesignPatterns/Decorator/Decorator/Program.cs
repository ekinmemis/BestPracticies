namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Window window1 = new LoginWindow("Sisteme Giriş");
            Window window2 = new ReportWindow("Stok raporu ekranı");
            Window window3 = new ReportWindow("Satış raporu ekranı");

            ScrollDecorator decorator1 = new ScrollDecorator(window2, "Stok raporu ekranı");
            ThemeDecorator decorator2 = new ThemeDecorator(window1, "Sisteme giriş");
            ThemeDecorator decorator3 = new ThemeDecorator(window3, "Satış raporu ekranı");
            ThemeDecorator decorator4 = new ThemeDecorator(window2, "Stok raporu ekranı");

            decorator1.ScrollBy(5);
            decorator2.SetTheme("Yaz");
            decorator3.SetTheme("Kış");
            decorator4.SetTheme("Sonbahar");
        }
    }
}
