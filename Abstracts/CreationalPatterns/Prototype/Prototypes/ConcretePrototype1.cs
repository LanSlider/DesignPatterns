namespace Prototype.Prototypes
{
    class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(int id)
            : base (id)
        { }

        public override Prototype Clone()
        {
            return this.MemberwiseClone() as Prototype;
        }
    }
}
