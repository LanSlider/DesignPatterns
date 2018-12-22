namespace Prototype.Prototypes
{
    abstract class Prototype
    {
        public int Id { get; set; }

        protected Prototype(int id)
        {
            Id = id;
        }

        public abstract Prototype Clone();
    }
}
