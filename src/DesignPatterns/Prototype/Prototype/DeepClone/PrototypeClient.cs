using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.DeepClone
{
    [Serializable]
    public class PrototypeClient : PrototypeHelper<Account>
    {
        public static void Display(Account account1, Account account2)
        {
            Console.WriteLine("Prototype: " + account1 + " Clone: " + account2);
        }
    }
}
