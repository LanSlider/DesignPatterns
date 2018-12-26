using System;

namespace Prototype_Example.Prototype
{
    abstract class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }

        protected Animal(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract Animal Clone();
    }
}
