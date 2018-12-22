using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    class ConcreteFactoryA : AbstractFactory
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
