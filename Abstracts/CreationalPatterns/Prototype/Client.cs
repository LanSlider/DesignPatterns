namespace Prototype
{
    class Client
    {
        private readonly Prototypes.Prototype _prototype;

        public Client(Prototypes.Prototype prototype)
        {
            _prototype = prototype;
        }

        public Prototypes.Prototype GetPrototype(int id)
        {
            return _prototype.Clone();
        }
    }
}
