namespace Visitor
{
    class TextBox:Control
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

    }
}
