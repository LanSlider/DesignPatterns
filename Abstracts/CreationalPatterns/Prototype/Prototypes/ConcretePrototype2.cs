namespace Prototype.Prototypes
{
    class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(int id)
            : base(id)
        { }

        public override Prototype Clone()
        {
            return this.MemberwiseClone() as Prototype;
        }
    }
}
