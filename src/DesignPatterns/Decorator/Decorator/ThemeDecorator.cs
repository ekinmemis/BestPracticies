using System;

namespace Decorator
{
    class ThemeDecorator : WindowDecorator
    {
        public ThemeDecorator(Window targetWindow, string title) : base(targetWindow, title)
        {
        }

        public override void Render()
        {
            this.TargetWindow.Render();
        }


        public void SetTheme(string name)
        {
            Console.WriteLine("{0} başlıklı pencereye {1} teması uygulandı",TargetWindow.Title,name);
            Render();
        }
    }
}
