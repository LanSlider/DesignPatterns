using FactoryMethod_Example.Products;

namespace FactoryMethod_Example.Creators
{
    abstract class PenCreator
    {
        public abstract Pen CreatePen();
    }
}
