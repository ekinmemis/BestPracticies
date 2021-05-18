using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.DeepClone
{
    [Serializable]
    public class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        
        public Customer(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }
        
        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}
