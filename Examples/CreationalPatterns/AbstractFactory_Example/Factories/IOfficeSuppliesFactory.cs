using AbstractFactory_Example.Products.Pencils;
using AbstractFactory_Example.Products.Pens;

namespace AbstractFactory_Example.Factories
{
    interface IOfficeSuppliesFactory
    {
        Pen CreatePen();
        Pencil CreatePencil();
    }
}
