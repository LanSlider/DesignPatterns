namespace Prototype_Example.Prototype
{
    class Cow : Animal
    {
        public Cow(int id, string name) : base(id, name)
        { }

        public override Animal Clone()
        {
            return (Animal)this.MemberwiseClone();
        }
    }
}
