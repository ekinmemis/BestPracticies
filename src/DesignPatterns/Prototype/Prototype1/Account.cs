using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype1
{
    [Serializable]
    public class Account : PrototypeHelper<Account>
    {
        public decimal Balance { get; set; }
        public Customer Customer { get; set; }

        public Account(decimal balance, string customerName, string customerSurname)
        {
            Balance = balance;
            Customer = new Customer(customerName, customerSurname);
        }

        public override string ToString()
        {
            return Customer.ToString() + " " + Balance;
        }
    }
}
