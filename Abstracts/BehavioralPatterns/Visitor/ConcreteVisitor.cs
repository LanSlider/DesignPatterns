namespace Visitor
{
    class ConcreteVisitor : IVisitor
    {
        public void Visit(ComponentA component)
        {
            throw new System.NotImplementedException();
        }

        public void Visit(ComponentB component)
        {
            throw new System.NotImplementedException();
        }
    }
}
