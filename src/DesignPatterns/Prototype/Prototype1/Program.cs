using System;

namespace Prototype1
{
    class Program
    {
        static void Main(string[] args)
        {

            PrototypeManager pm = new PrototypeManager();

            Console.WriteLine("-----Shallow Clone-----\n");

            Account account = pm.Accounts[1].ShallowClone();
            PrototypeClient.Display(pm.Accounts[1], account);

            account.Balance = 9999;
            PrototypeClient.Display(pm.Accounts[1], account);

            account.Customer.Surname = "......";
            PrototypeClient.Display(pm.Accounts[1], account);

            Console.WriteLine("\n-----Deep Clone-----\n");

            Account account2 = pm.Accounts[2].DeepClone();
            PrototypeClient.Display(pm.Accounts[2], account2);

            account2.Balance = 123456;
            PrototypeClient.Display(pm.Accounts[2], account2);

            account2.Customer.Name = "......";
            PrototypeClient.Display(pm.Accounts[2], account2);

        }
    }
}
