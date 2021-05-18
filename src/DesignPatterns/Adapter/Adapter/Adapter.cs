using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Adapter
    {
        private Adaptee _adaptee;
        public Adapter()
        {
            _adaptee = new Adaptee();
        }
        public void MessageDialog(string title, string text, Buttons buttons)
        {
            _adaptee.Alert(title, text, buttons);
        }
    }
}
