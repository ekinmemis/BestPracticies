namespace Builder
{
    class ConcreteBuilder1 : Builder
    {
        private Product _product = new Product();
        public override void BuildPart(string partName)
        {
            _product.Add(partName);
        }

        public override Product GetProduct()
        {
            return _product;
        }
    }
}
