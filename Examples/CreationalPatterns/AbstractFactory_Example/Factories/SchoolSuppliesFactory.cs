using AbstractFactory_Example.Products.Pencils;
using AbstractFactory_Example.Products.Pens;

namespace AbstractFactory_Example.Factories
{
    class SchoolSuppliesFactory : IOfficeSuppliesFactory
    {
        public Pen CreatePen()
        {
            return new BallpointPen();
        }

        public Pencil CreatePencil()
        {
            return new SimplePencil();
        }
    }
}
