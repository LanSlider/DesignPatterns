using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
}
