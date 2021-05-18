namespace Visitor
{
    class DropdownList:Control
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
