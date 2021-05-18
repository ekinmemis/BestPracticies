using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Adapter adp = new Adapter();
            adp.MessageDialog("CSD", "Özgürlük için Linux'u seçin", Buttons.OKCancel);
        }
    }
}
