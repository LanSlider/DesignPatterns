using FactoryMethod.Product;

namespace FactoryMethod
{
    class ConcreteCreatorA : Creator
    {
        public override Product.Product CreateProduct()
        {
            return new ConcreteProductA();
        }
    }
}
