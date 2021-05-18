using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Adapter
{
    class Adaptee
    {
        [DllImport("user32.dll", EntryPoint = "MessageBox", CallingConvention = CallingConvention.Winapi)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint buttons);

        public void Alert(string title, string message, Buttons combination)
        {
            MessageBox(new IntPtr(), message, title, (uint)combination);
        }
    }
}
