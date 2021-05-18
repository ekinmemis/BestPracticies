using System;

namespace Visitor
{
    class ControlsVisitor : IVisitor
    {
        public void Visit(Control control)
        {
            if (control is DropdownList)
                Console.WriteLine("Dropdown'da child eleman eklenemez");
            if (control is Panel)
                Console.WriteLine("Panel'de child eleman eklenebilir");
            if (control is TextBox)
                Console.WriteLine("Textbox'ta child eleman eklenemez");

        }
    }
}
