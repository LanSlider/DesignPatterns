
using Decorator.Components;

namespace Decorator.Decorators
{
    abstract class Decorator : IComponent
    {
        protected IComponent Component { get; set; }

        public void SetComponent(IComponent component)
        {
            Component = component;
        }

        public void SomeOperation()
        {
            if (Component != null)
            {
                Component.SomeOperation();
            }
        }
    }
}
