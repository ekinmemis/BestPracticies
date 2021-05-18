using System;

namespace Decorator
{
    class ScrollDecorator : WindowDecorator
    {
        public ScrollDecorator(Window targetWindow, string title) : base(targetWindow, title)
        {

        }

        public override void Render()
        {
            TargetWindow.Render();
        }


        public void ScrollBy(int amount)
        {
            Console.WriteLine("{0} başlıklı pencere {1} birim kaydırıldı",TargetWindow.Title,amount);
            Render();
        }


    }
}
