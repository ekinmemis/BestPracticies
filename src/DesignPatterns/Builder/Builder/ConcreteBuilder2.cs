namespace Builder
{
    class ConcreteBuilder2 : Builder
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
