namespace Prototype_Example.Prototype
{
    class Sheep : Animal
    {
        public Sheep(int id, string name) : base(id, name)
        { }

        public override Animal Clone()
        {
            return (Animal)this.MemberwiseClone();
        }
    }
}
