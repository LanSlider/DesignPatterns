using System;

namespace FactoryMethod
{
    class ConcreteProductB : Creator
    {
        public override Product.Product CreateProduct()
        {
            return new Product.ConcreteProductB();
        }
    }
}
