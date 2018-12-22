using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    class ConcreteFactoryB : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            throw new System.NotImplementedException();
        }

        public override AbstractProductB CreateProductB()
        {
            throw new System.NotImplementedException();
        }
    }
}
