namespace Decorator
{
    abstract class Window
    {
        protected string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }


        public Window()
        {
            Title = "";
        }

        public Window(string title)
        {
            Title = title;
        }

        public abstract void Render();
    }
}
