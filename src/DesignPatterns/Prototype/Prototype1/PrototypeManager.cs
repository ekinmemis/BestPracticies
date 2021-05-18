using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype1
{
    [Serializable]
    public class PrototypeManager : PrototypeHelper<Account>
    {
        public Dictionary<int, Account> Accounts = new Dictionary<int, Account>
        {
            {1, new Account(1000,"Ekin","Memiş") },
            {2, new Account(1000,"Bayram","Alpak") },
            {3, new Account(1000,"Kıvanç","Balmumcu") },
        };
    }
}
