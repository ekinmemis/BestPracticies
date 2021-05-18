using Optimus.NewTypes.Pets;
using System;
using System.Collections.Generic;

namespace Optimus
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<IPet> pets = new List<IPet>()
            {
                new Dog(),
                new Cat(),
                new Bird()
            };

            foreach (var pet in pets)
                Console.WriteLine(pet.TalkToOwner());
        }
    }
}
