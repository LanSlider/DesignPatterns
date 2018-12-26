using Prototype_Example.Prototype;

namespace Prototype_Example
{
    class Client
    {
        public Animal GetClone(Animal animal)
        {
            return animal.Clone();
        }
    }
}
