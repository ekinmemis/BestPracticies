namespace Decorator
{
    abstract class WindowDecorator : Window
    {
        
        public Window TargetWindow { get; set; }

        public WindowDecorator(Window targetWindow,string title)
        {
            TargetWindow.Title = title;
            TargetWindow = targetWindow;
        }
    }
}
