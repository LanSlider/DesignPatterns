namespace Builder
{
    class Director
    {
        private readonly Builders.Builder _builder;

        public Director(Builders.Builder builder)
        {
            _builder = builder;
        }

        public void Build()
        {
            _builder.BuildPartA();
            _builder.BuildPartB();
            _builder.BuildPartC();
        }
    }
}
