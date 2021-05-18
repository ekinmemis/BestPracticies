using System;

namespace Decorator
{
    class LoginWindow : Window
    {
        public LoginWindow()
        {

        }
        public LoginWindow(string title) : base(title)
        {

        }
        public override void Render()
        {
            Console.WriteLine("{0} başlıklı login ekranı render edildi", Title);
        }
    }
}
