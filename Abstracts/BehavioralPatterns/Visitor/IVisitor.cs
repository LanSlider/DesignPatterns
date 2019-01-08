namespace Visitor
{
    interface IVisitor
    {
        void Visit(ComponentA component);
        void Visit(ComponentB component);
    }
}
