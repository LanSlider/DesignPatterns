namespace Builder.Builders
{
    class ConcreteBuilder : Builder
    {
        private readonly Product _product;

        public ConcreteBuilder()
        {
            _product = new Product();
        }

        public override void BuildPartA()
        {
            throw new System.NotImplementedException();
        }

        public override void BuildPartB()
        {
            throw new System.NotImplementedException();
        }

        public override void BuildPartC()
        {
            throw new System.NotImplementedException();
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}
