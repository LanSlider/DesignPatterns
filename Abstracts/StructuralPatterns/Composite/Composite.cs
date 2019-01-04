using System.Collections.Generic;

namespace Composite
{
    class Composite : IComponent
    {
        private readonly List<Component> _componentList;

        public Composite()
        {
            _componentList = new List<Component>();
        }

        public void Add(Component component)
        {
            _componentList.Add(component);
        }

        public void Del(Component component)
        {
            _componentList.Remove(component);
        }

        public Component Find(Component component)
        {
            return _componentList.Find(x => x.Equals(component));
        }

        public void Operation()
        {
            foreach (var component in _componentList)
            {
                component.Operation();
            }
        }
    }
}
