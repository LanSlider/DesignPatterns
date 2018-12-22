using AbstractFactory_Example.Products.Pencils;
using AbstractFactory_Example.Products.Pens;

namespace AbstractFactory_Example.Factories
{
    class KinderGartenSuppliesFactory : IOfficeSuppliesFactory
    {
        public Pen CreatePen()
        {
            return new GelPen();
        }

        public Pencil CreatePencil()
        {
            return  new ColorPencil();
        }
    }
}
