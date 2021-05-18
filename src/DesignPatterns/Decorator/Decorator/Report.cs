using System;

namespace Decorator
{
    class ReportWindow : Window
    {
        public ReportWindow()
        {

        }
        public ReportWindow(string title) : base(title)
        {

        }
        public override void Render()
        {
            Console.WriteLine("{0} başlıklı rapor ekranı render edildi", Title);
        }
    }
}
