using System;

namespace Visitor
{
    class StatefulVisitor : IVisitor
    {
        public void Visit(Control control)
        {
            if(control is DropdownList)
                Console.WriteLine("Dropdown'da viewstate kullanılıyor");
            if(control is Panel)
                Console.WriteLine("Panel'de viewstate kullanılıyor");
            if (control is TextBox)
                Console.WriteLine("Textbox'ta viewstate kullanılıyor");
        }
    }
}
