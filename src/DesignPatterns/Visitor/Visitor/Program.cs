namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Panel panel = new Panel();
            DropdownList dropdownList = new DropdownList();
            TextBox textBox = new TextBox();

            ControlsVisitor controlsVisitor = new ControlsVisitor();
            controlsVisitor.Visit(panel);
            controlsVisitor.Visit(dropdownList);
            controlsVisitor.Visit(textBox);

            StatefulVisitor statefulVisitor = new StatefulVisitor();
            statefulVisitor.Visit(panel);
            statefulVisitor.Visit(dropdownList);
            statefulVisitor.Visit(textBox);
        }
    }
}
