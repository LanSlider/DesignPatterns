namespace AbstractFactory
{
    class Client
    {
        private readonly Factories.AbstractFactory _abstractFactory;

        public Client(Factories.AbstractFactory abstractFactory)
        {
            _abstractFactory = abstractFactory;
        }

        public void Run()
        {
            //_abstractFactory.CreateProductA();
            //_abstractFactory.CreateProductB();
        }
    }
}
