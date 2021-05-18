namespace Bridge
{
    public class Abstraction
    {
        protected Implementor implementor;

        public Implementor Iplementor
        {
            set { implementor = value; }
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }

    }
}
