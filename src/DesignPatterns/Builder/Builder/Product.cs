using System.Collections.Generic;

namespace Builder
{
    class Product
    {
        private List<string> parts = new List<string>();
        public void Add(string partName)
        {
            parts.Add(partName);
        }

        public override string ToString()
        {
            string vs = "Ürüne ait parcalar \n\r";

            foreach (var item in parts)
                vs += item + "\n\r";

            return vs;
        }
    }
}
