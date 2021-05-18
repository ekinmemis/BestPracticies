namespace Visitor
{
    abstract class Control
    {
        public abstract void Accept(IVisitor visitor);
        public int Id { get; protected set; }
        public string Text { get; protected set; }


    }
}
