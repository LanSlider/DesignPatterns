using FactoryMethod_Example.Products;

namespace FactoryMethod_Example.Creators
{
    class GelPenCreator : PenCreator
    {
        public override Pen CreatePen()
        {
            return new GelPen();
        }
    }
}
